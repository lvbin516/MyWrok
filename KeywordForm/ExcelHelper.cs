using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using SearchEngin;
using System.Windows.Forms;


namespace Excel
{
    class ExcelHelper
    {
        public static void exportExcel(string enginName, string keyword, string saveFileName, List<SearchTerm> result)
        {

            if (string.IsNullOrEmpty(saveFileName))
            {
                return;
            }
            string title = enginName + " - " + keyword;
            Microsoft.Office.Interop.Excel.Application xls = null;
            Workbook workbook = null;
            try
            {
                xls = new Microsoft.Office.Interop.Excel.Application();
                workbook = xls.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Worksheet worksheet = workbook.Worksheets[1] as Worksheet;
                addRange(worksheet, "A1", "B2", System.Drawing.Color.Green.ToArgb(), title, 20);
                addCell(worksheet, 4, 1, System.Drawing.Color.Gray.ToArgb(), "Search Terms", 20);
                addCell(worksheet, 4, 2, System.Drawing.Color.Gray.ToArgb(), "Keywords", 20);
                for (int i = 0; i < result.Count; i++ )
                {
                    addCell(worksheet, i + 5, 1, System.Drawing.Color.White.ToArgb(), result[i].Term, 20);
                    addCell(worksheet, i + 5, 2, System.Drawing.Color.White.ToArgb(), result[i].Keyword, 20);
                }
                worksheet.SaveAs(saveFileName, XlFileFormat.xlTemplate, Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close(true, Type.Missing, Type.Missing);
                }
                if (xls != null)
                {
                    xls.Quit();
                }
            }
        }

        private static void addRange(Worksheet worksheet, string startCell, string endCell, int color, string text, int columnWidth)
        {
            if (worksheet == null)
            {
                return;
            }
            Range range = worksheet.get_Range(startCell, endCell);
            range.MergeCells = true;
            range.Interior.Color = color;
            range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            range.ColumnWidth = columnWidth;
            range.Font.Color = System.Drawing.Color.Black.ToArgb();
            range.NumberFormat = null;
            range.Value2 = text;
        }

        private static void addCell(Worksheet worksheet, int row, int col, int color, string text, int columnWidth)
        {
            if (worksheet == null)
            {
                return;
            }
            worksheet.Cells[row, col] = text;
            Range range = worksheet.Cells[row, col] as Range;
            range.MergeCells = false;
            range.Interior.Color = color;
            range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            range.ColumnWidth = columnWidth;
            range.Font.Color = System.Drawing.Color.Black.ToArgb();
            range.NumberFormat = null;
        }

    }
}
