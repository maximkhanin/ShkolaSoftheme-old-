using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ReplaceText
    {
        private const int MaxDegreeOfParallelism = 5;
        private readonly string _oldText;
        private readonly string _newText;

        public ReplaceText(string oldText, string newText)
        {
            _oldText = oldText;
            _newText = newText;
            var fileStream = File.Create("log.txt");
            fileStream.Close();      
        }

        public void ReplaceTextInFiles(string path)
        {
            var dirs = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path, "*.txt");

            Parallel.ForEach(files, x =>
            {
                new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism };
                Console.WriteLine(x);
                var streamReader = File.OpenText(x);
                var text = String.Empty;
                var str = String.Empty;
                var logFile = String.Empty;
                while ((str = streamReader.ReadLine())!=null)
                {
                    if (str.Contains(_oldText))
                    {
                        logFile += "Name of the file: " + x + " String:" + str;
                        str = str.Replace(_oldText, _newText);
                        logFile +=" Result:" + str + "\r\n";
                    }
                    text += str + "\r\n";
                }
                streamReader.Close();
                File.WriteAllText(x, text);
                lock (this)
                {
                   File.AppendAllText("log.txt", logFile);
                }  
            });

            Parallel.ForEach(dirs, x =>
            {
                new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism };
                ReplaceTextInFiles(x);
            });
        }
    }
}
