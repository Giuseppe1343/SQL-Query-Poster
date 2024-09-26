using DevExpress.Spreadsheet;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMailUI
{
    internal class ExcelGenerator
    {
        // type preview = 1;
        // type excel = 2;
        // type mail.excel = 3;
        // type mail.html = 4;

        public string MainGenerate(IEnumerable<dynamic> data, int export_type, int table_theme, string sorgu_adi = "")
        {
            string ExportPath = string.Empty;

            if (data == null)
            {
                MessageBox.Show("Girilen sorgu hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (data.Count() == 0)
            {
                MessageBox.Show("Girilen boş tablo döndürüyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        if (table_theme > 0 && export_type != 4)
                        {
                            tbl.Style = workbook.TableStyles[(BuiltInTableStyleId)table_theme];
                            tbl.ShowTotals = true;
                            // Sum all values in every column.
                            //for (int i = 0; i < tbl.Columns.Count; i++)
                            //    tbl.Columns[i].TotalRowFunction = TotalRowFunction.Sum;
                        }
                        else if (table_theme > 0 && export_type == 4) tbl.Style = workbook.TableStyles[(BuiltInTableStyleId)table_theme];
                        else if (table_theme == 0 && export_type == 4) tbl.Range.Style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    }

                    finally
                    {
                        workbook.EndUpdate();
                    }


                    // Save the document file for the specified job.
                    if (export_type == 1) // Preview
                    {
                        ExportPath = "Preview.xlsx";
                        workbook.SaveDocument(ExportPath, DocumentFormat.OpenXml);
                        System.Diagnostics.Process.Start(ExportPath);
                    }

                    else if (export_type == 2) // Excel Save
                    {
                        string exportPath = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("FilePath").GetValue("Path").ToString();
                        FolderBrowserDialog fbd = new FolderBrowserDialog();
                        fbd.Description = "Lütfen Excelin kaydedileceği yolu seçin.";
                        fbd.SelectedPath = exportPath;
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            if (fbd.SelectedPath != exportPath)
                            {
                                exportPath = fbd.SelectedPath;
                                Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("PMail").CreateSubKey("FilePath").SetValue("Path", exportPath);
                            }
                        }
                        workbook.SaveDocument(exportPath + "\\" + sorgu_adi + DateTime.Now.ToString("_yyyy-MM-dd-HHmm") + ".xlsx", DocumentFormat.OpenXml);
                        ExportPath = exportPath;
                    }
                    else if (export_type == 3) // Mail Attachment
                    {
                        ExportPath = sorgu_adi + DateTime.Now.ToString("_yyyy-MM-dd-HHmm") + ".xlsx";
                        workbook.SaveDocument(ExportPath, DocumentFormat.OpenXml);
                    }
                    else if (export_type == 4) // Mail Body html
                    {
                        ExportPath = "MailBody.html";
                        workbook.ExportToHtml(ExportPath, worksheet);
                    }

                }
            }
            return ExportPath;
        }
    }
}
