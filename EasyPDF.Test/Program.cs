using iText.Layout.Element;
using System;
using System.Collections.Generic;

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
                "hamada".AsText().AddToDocument(doc);
                var table = new Table(3, true);
                var headers = new List<string>() { "sfdds", "fsf", "sfdsfsd" };
                headers.AsHeaderRow().AddToTable(table);
                doc.Add(table);
                pdf.AddPageNumberAsFooter(doc);
                return true; 
            });
        }
    }
}
