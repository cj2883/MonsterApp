using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace DND.Controllers
{
    public class ExcelController
    {
        public void ExportDataSetToExcel(DataSet ds, string filePath)
        {
            //Creae an Excel application instance
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            Excel.Workbook excelWorkBook;

            //Create an Excel workbook instance and open it from the predefined location
            if (File.Exists(filePath))
                File.Delete(filePath);

            excelApp.SheetsInNewWorkbook = 1;
            excelWorkBook = (Excel.Workbook)(excelApp.Workbooks.Add(Missing.Value));
            excelWorkBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookDefault,
                null, null, false, false, Excel.XlSaveAsAccessMode.xlShared,
                false, false, null, null, null);

            foreach (DataTable table in ds.Tables)
            {
                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;

                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }
            }

            excelWorkBook.Save();
            excelWorkBook.Close();
            excelApp.Quit();

        }
    }
}
