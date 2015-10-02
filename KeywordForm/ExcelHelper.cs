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
        public static void exportExcel(string enginName, string keyword, List<SearchTerm> result)
        {
            if(result == null || result.Count == 0)
            {
                MessageBox.Show("结果为空");
                return ;
            }
            string title = enginName + " - " + keyword;
            //选择框
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.AddExtension = true;
            saveDialog.Filter = "Excel 文件|*.xls";
            saveDialog.FileName = title + ".xls";
            //保存对话框是否记忆上次打开的目录
            saveDialog.RestoreDirectory = true;
            DialogResult saveResult = saveDialog.ShowDialog();
            if (saveResult == DialogResult.Cancel)
            {
                return;
            }
            string saveFileName = saveDialog.FileName;
            MessageBox.Show("选择的文件为：\r\n" + saveFileName);
            if (string.IsNullOrEmpty(saveFileName))
            {
                return;
            }
            Microsoft.Office.Interop.Excel.Application xls = null;
            Workbook workbook = null;
            try
            {
                xls = new Microsoft.Office.Interop.Excel.Application();
                if (xls == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能你还未安装Excel!");
                    return;
                }
                workbook = xls.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Worksheet worksheet = workbook.Worksheets[1] as Worksheet;
                addRange(worksheet, "C3", "D4", System.Drawing.Color.Green.ToArgb(), title, 20);
                addCell(worksheet, 6, 3, System.Drawing.Color.Gray.ToArgb(), "Search Terms", 20);
                addCell(worksheet, 6, 4, System.Drawing.Color.Gray.ToArgb(), "Keywords", 20);
                for (int i = 0; i < result.Count; i++ )
                {
                    addCell(worksheet, i + 7, 3, System.Drawing.Color.White.ToArgb(), result[i].Term, 20);
                    addCell(worksheet, i + 7, 4, System.Drawing.Color.White.ToArgb(), result[i].Keyword, 20);
                }
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
