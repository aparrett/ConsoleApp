using System;
using System.Collections.Generic;
using CSharpFundamentals;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
