using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Linq;

namespace EasyPDF
{
    public static class DocumentHelper
    {
        public static void AddToDocument(this Paragraph para,Document doc) =>
            doc.Add(para);

        public static void AddToDocument(this Table table, Document doc) =>
           doc.Add(table);

        public static void AddPageNumberAsFooter(this PdfDocument pdf, Document doc)
        {
            var n = pdf.GetNumberOfPages();
            
            Enumerable.Range(1, n)
                      .ToList()
                      .ForEach(i =>
                      {
                          var rect = pdf.GetPage(i).GetPageSize();
                          var width = rect.GetWidth();
                          var para =new Paragraph( $"page {i} of {n}");
                          doc.ShowTextAligned(para, width/2, 50, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                      });
        }

    }
}
