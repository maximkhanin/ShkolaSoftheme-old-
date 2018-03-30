using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ionic.Zip;

namespace ConsoleApp1
{
    static class Program
    {
        static int count = 0;
        static object locker = new object();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.WriteLine("Input the path to the directory");
            var path = Console.ReadLine();
            Console.WriteLine("Input the name of the archive");
            var archiveName = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                return;
            }
            MakeZipFile(path, archiveName);
        }

        private static void MakeZipFile(string path, string archiveName)
        {
            try
            {
                using (var zipFile = new ZipFile(Encoding.UTF8))
                {
                    zipFile.UseZip64WhenSaving = Zip64Option.AsNecessary;

                    var threadParams = new ThreadParams();
                    threadParams.ZipFile = zipFile;
                    threadParams.Path = path;

                    ZipDirectory(threadParams);

                    zipFile.Save(archiveName + ".zip");
                }

            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
            }

        }

        private static void ZipDirectory(object obj)
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            var threadParams = (ThreadParams) obj;

            var dirs = Directory.GetDirectories(threadParams.Path);
            var files = Directory.GetFiles(threadParams.Path);

            foreach (var file in files)
            {
                threadParams.ZipFile.AddItem(file, threadParams.Path);
            }

            foreach (var itemDir in dirs)
            {
                Thread myThread = new Thread(new ParameterizedThreadStart(ZipDirectory));
                myThread.Name = "Thread - " + count;
                var itemThreadParams= new ThreadParams();
                itemThreadParams.ZipFile = threadParams.ZipFile;
                itemThreadParams.Path = itemDir;
                count++;
                myThread.Start(itemThreadParams);
            }

        }
    }
}
