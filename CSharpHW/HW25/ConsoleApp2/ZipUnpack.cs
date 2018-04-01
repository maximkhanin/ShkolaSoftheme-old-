﻿using System;
using System.IO;
using System.Threading.Tasks;
using Ionic.Zip;

namespace ConsoleApp2
{
    class ZipUnpack
    {
        private const int MaxDegreeOfParallelism = 5;

        public void ExtractAllZip(string path)
        {
            var dirs = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path, "*.zip");

            Parallel.ForEach(files, x =>
            {
                new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism };
                Console.WriteLine(x);
                var zipFile = ZipFile.Read(x);
                zipFile.ExtractAll(path, ExtractExistingFileAction.OverwriteSilently);
            });

            Parallel.ForEach(dirs, x =>
            {
                new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism };
                ExtractAllZip(x);
            });
        }
    }
}