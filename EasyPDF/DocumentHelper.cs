using iText.Layout;
using iText.Layout.Element;

namespace EasyPDF
{
    public static class DocumentHelper
    {
        public static void AddToDocument(this Paragraph para,Document doc) =>
            doc.Add(para);
    }
}
