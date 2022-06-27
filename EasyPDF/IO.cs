using iText.Kernel.Pdf;
using iText.Layout;
using System;

namespace EasyPDF
{
    public static class IO
    {
        /// <summary>
        /// Write Pdf to the specified File.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName">File full path</param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T WritePdf<T>(this string fileName,Func<PdfDocument,Document,T> func)
        {
            using (var writer = new PdfWriter(fileName))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);
                    var result = func(pdf,doc);
                    return result;
                }
            }
        }
    }
}
