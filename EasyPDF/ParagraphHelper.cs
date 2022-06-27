using iText.Layout.Element;
using iText.Layout.Properties;

namespace EasyPDF
{
    public static class ParagraphHelper
    {
        public static Paragraph AsTitle(this string title)
        {
            var para = new Paragraph(title)
                          .SetTextAlignment(TextAlignment.CENTER)
                          .SetFontSize(22)
                          .SetBold()
                          .SetUnderline();
                         
            return para;
        }
    }
}
