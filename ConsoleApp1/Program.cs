using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CSharpFundamentals;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\myfile.jpg";
            File.Copy(path, @"C:\temp\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"C:\temp\temp\myfile.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
