using System;
using System.IO;

namespace Lab_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
