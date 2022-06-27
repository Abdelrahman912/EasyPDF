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
                          .SetFontSize(20)
                          .SetBold()
                          .SetUnderline();
                         
            return para;
        }

        public static Paragraph AsSubTitle(this string subTitle)
        {
            var para = new Paragraph(subTitle)
                          .SetTextAlignment(TextAlignment.LEFT)
                          .SetFontSize(16)
                          .SetBold();
            return para;
        }
        public static Paragraph AsText(this string text)
        {
            var para = new Paragraph(text)
                          .SetTextAlignment(TextAlignment.LEFT)
                          .SetFontSize(14);
            return para;
        }
    }
}
