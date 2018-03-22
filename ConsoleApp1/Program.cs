using System;
using System.Collections.Generic;
using System.Text;
using CSharpFundamentals;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new String('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine(builder[0]);
        }
    }
}
