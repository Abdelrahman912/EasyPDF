using System;

namespace EasyPDF.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var fileName = @"D:\Work\Programming\hamada.pdf";
            fileName.WritePdf((pdf,doc) => 
            { 
                "Test".AsTitle().AddToDocument(doc); 
                pdf.AddPageNumberAsFooter(doc);
                return true; 
            });
        }
    }
}
