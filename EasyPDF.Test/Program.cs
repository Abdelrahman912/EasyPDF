using System;

namespace EasyPDF.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var fileName = @"D:\Work\Programming\hamada.pdf";
            fileName.WritePdf(doc => { "Test".AsTitle().AddToDocument(doc); return true; });
        }
    }
}
