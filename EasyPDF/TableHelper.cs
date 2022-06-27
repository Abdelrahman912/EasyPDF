using iText.Kernel.Colors;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Collections.Generic;
using System.Linq;

namespace EasyPDF
{
    public static class TableHelper
    {
        public static Cell AsHeaderCell(this string header)
        {
            var cell = new Cell(1,1)
                           .SetTextAlignment(TextAlignment.CENTER)
                           .SetBackgroundColor(ColorConstants.GRAY)
                           .SetFontSize(14)
                           .Add(new Paragraph(header));
            return cell;
        }

        public static Cell AsLeftTextCell(this string text)
        {
            var cell = new Cell(1, 1)
                           .SetTextAlignment(TextAlignment.LEFT)
                           .SetFontSize(12)
                           .Add(new Paragraph(text));
            return cell;
        }
        public static Cell AsCenterTextCell(this string text)
        {
            var cell = new Cell(1, 1)
                           .SetTextAlignment(TextAlignment.LEFT)
                           .SetFontSize(12)
                           .Add(new Paragraph(text));
            return cell;
        }

        public static IEnumerable<Cell> AsHeaderRow(this IEnumerable<string> headers) =>
            headers.Select(head => head.AsHeaderCell());

        public static IEnumerable<Cell> AsLeftTextRow(this IEnumerable<string> rows) =>
           rows.Select(c => c.AsLeftTextCell());

        public static IEnumerable<Cell> AsCenterTextRow(this IEnumerable<string> rows) =>
          rows.Select(c => c.AsCenterTextCell());

        public static void AddToTable(this Cell cell,Table table)=>
            table.AddCell(cell);

        public static void AddToTable(this IEnumerable<Cell> row, Table table) =>
            row.ToList().ForEach(c => table.AddCell(c));
    }
}
