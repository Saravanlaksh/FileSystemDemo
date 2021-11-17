using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"D:\Temp\Demos\FileSystem";
            string[] dirs = Directory.GetDirectories(rootpath);

            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetFullPath(file));
                Console.WriteLine(Path.GetDirectoryName(file));
                var info = new FileInfo(file);

                Console.WriteLine($"{ Path.GetFileName(file)}: {info.Length} bytes");
            }
            // string newPath = @"D:\Temp\Demos\FileSystem\SubFolderD";
            // Directory.CreateDirectory(newPath);
            //bool directoryExists = Directory.Exists(@"D:\Temp\Demos\FileSystem\SubFolderC");
            // if(directoryExists)
            // {
            //     Console.WriteLine("The directory exists");
            // }
            // else
            // {
            //     Console.WriteLine("The directory does not exists");
            //     Directory.CreateDirectory(newPath);
            // }
            // Console.ReadLine();

            //string[] files = Directory.GetFiles(rootpath);
            //string destinationfolder = @"D:\Temp\Demos\FileSystem\SubFolderA\";
            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationfolder}{ Path.GetFileName(file)}", true);
            //}
            Console.ReadLine();
        }
    }
}
