using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using lg = PMailCore.LogIslem;


namespace PMailCore.Managers
{
    internal class ExcelGenerator
    {
        // bool Error or Success
        // string ErrorCode or Path
        // every condition system backup html body as excel file
        public (bool, string) MainGenerate(IEnumerable<dynamic> data, bool isBodyHTML, int table_theme, string plan_adi)
        {
            string ExportPath = string.Empty;

            if (data == null)
            {
                return (false, ("Plan Adı: " + plan_adi + " Hata(Excel): Girilen sorgu hatalı.").ToLogString());
            }
            else if (data.Count() == 0)
            {
                return (false, ("Plan Adı: " + plan_adi + " Uyarı(Excel): Girilen sorgu boş tablo döndürüyor.").ToLogString());
            }
            else
            {
                // Create a new workbook.
                using (Workbook workbook = new Workbook())
                {
                    var dapperRows = data.Cast<IDictionary<string, object>>().ToList();

                    // Access the first worksheet in the workbook.
                    Worksheet worksheet = workbook.Worksheets[0];

                    // Set the unit of measurement.
                    workbook.Unit = DevExpress.Office.DocumentUnit.Point;

                    workbook.BeginUpdate();
                    try
                    {
                        // Get headers row from data to Excel.
                        foreach (var key in dapperRows.First().Keys.Select((k, index) => new { value = k, index = index }))
                            worksheet.Cells[0, key.index].Value = key.value;

                        // Set header row bold.
                        worksheet.Rows[0].Font.Bold = true;

                        // Get body row from data to Excel.
                        var rowNumber = 1;
                        int intValue;
                        double doubleValue;
                        foreach (var row in dapperRows)
                        {
                            foreach (var rowValue in row.Select((r, index) => new { value = r.Value, index = index }))
                            {
                                //string stringValue = rowValue.value?.ToString();
                                //if (int.TryParse(stringValue, out intValue)) worksheet.Cells[rowNumber, rowValue.index].Value = intValue;
                                //else if (double.TryParse(stringValue, out doubleValue)) worksheet.Cells[rowNumber, rowValue.index].Value = doubleValue;
                                //else 
                                worksheet.Cells[rowNumber, rowValue.index].Value = (dynamic)rowValue.value;
                            }
                            rowNumber++;
                        }

                        // Define data in datarange and apply styles on it.
                        Table tbl = worksheet.Tables.Add(worksheet.GetDataRange(), true);
                        tbl.Range.AutoFitColumns();

                        if (table_theme > 0 && !isBodyHTML)
                        {
                            tbl.Style = workbook.TableStyles[(BuiltInTableStyleId)table_theme];
                            //tbl.ShowTotals = true;
                            // Sum all values in every column.
                            //for (int i = 0; i < tbl.Columns.Count; i++)
                            //    tbl.Columns[i].TotalRowFunction = TotalRowFunction.Sum;
                        }
                        else if (table_theme > 0 && isBodyHTML) tbl.Style = workbook.TableStyles[(BuiltInTableStyleId)table_theme];
                        else if (table_theme == 0 && isBodyHTML) tbl.Range.Style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    }

                    finally
                    {
                        workbook.EndUpdate();
                    }
                    try
                    {
                        if (!Directory.Exists(lg.ExcelDosyaKlasorYolu(plan_adi)))
                        {
                            Directory.CreateDirectory(lg.ExcelDosyaKlasorYolu(plan_adi));
                        }
                        ExportPath = lg.ExcelDosyaYolu(plan_adi/*+ "," + plan_id*/);
                        workbook.SaveDocument(ExportPath, DocumentFormat.OpenXml);
                        if (isBodyHTML)
                        {
                            ExportPath = plan_adi + DateTime.Now.ToString("_yyyy-MM-dd-HHmm") + ".html";
                            workbook.ExportToHtml(ExportPath, worksheet);

                        }
                    }
                    catch (Exception ex)
                    {
                        return (false, ("Plan Adı: " + plan_adi + " Hata(ExcelKayıt): " + ex).ToLogString());
                    }

                }
                return (true, ExportPath);
            }
        }
    }
}
