using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.tinhluongfrm
{
    public partial class ChamCongForm : UserControl
    {
        public ChamCongForm()
        {
            InitializeComponent();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";
            DataTable dataTable = new DataTable();

            // Kiểm tra xem người dùng đã chọn tệp hay chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                var o = new OpenSettings();
                // Mở tệp Excel
                using (SpreadsheetDocument document = SpreadsheetDocument.Open(filePath, false))
                {
                    WorkbookPart workbookPart = document.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                    // Lấy danh sách tất cả các cột từ hàng đầu tiên
                    Row headerRow = sheetData.Elements<Row>().FirstOrDefault();
                    if (headerRow != null)
                    {
                        foreach (Cell headerCell in headerRow.Elements<Cell>())
                        {
                            string columnName = GetCellValue(headerCell, workbookPart);
                            dataTable.Columns.Add(columnName);
                        }
                    }

                    // Lặp qua các hàng trong tệp Excel, bắt đầu từ hàng thứ 2
                    foreach (Row row in sheetData.Elements<Row>().Skip(1))
                    {
                        DataRow dataRow = dataTable.NewRow();
                        int columnIndex = 0;

                        // Lặp qua các ô trong mỗi hàng
                        foreach (Cell cell in row.Elements<Cell>())
                        {
                            string cellValue = GetCellValue(cell, workbookPart);
                            dataRow[columnIndex] = cellValue;
                            columnIndex++;
                        }

                        dataTable.Rows.Add(dataRow);
                    }
                }
            }

            dataGridViewChamCong.DataSource = dataTable;
        }

        private static string GetCellValue(Cell cell, WorkbookPart workbookPart)
        {
            string cellValue = string.Empty;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                int sharedStringId = int.Parse(cell.CellValue.Text);
                SharedStringTablePart sharedStringTablePart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                if (sharedStringTablePart != null)
                {
                    SharedStringTable sharedStringTable = sharedStringTablePart.SharedStringTable;
                    SharedStringItem sharedStringItem = sharedStringTable.Elements<SharedStringItem>().ElementAt(sharedStringId);
                    if (sharedStringItem.Text != null)
                    {
                        cellValue = sharedStringItem.Text.Text;
                    }
                }
            }
            else if (cell.CellValue != null)
            {
                cellValue = cell.CellValue.Text;
            }
            return cellValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Lưu tệp Excel";
            saveFileDialog.FileName = "cham_cong_template.xlsx";
            saveFileDialog.ShowDialog();

            try
            {
                if (saveFileDialog.FileName != "")
                {
                    File.Copy(Path.Combine(Application.StartupPath + @"\Resources\cham_cong_form.xlsx"), saveFileDialog.FileName);
                }
            } catch
            {
                File.Replace(Path.Combine(Application.StartupPath + @"\Resources\cham_cong_form.xlsx"), saveFileDialog.FileName, null);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridViewChamCong.DataSource;
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine(row[column]);
                }
            }
        }

        private void txtthang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.bangccs.Add(new bangcc() {
                so = txtso.Text,
                mabp = cbomabp.SelectedValue.ToString(),
                ngaycong = int.Parse(txtngaycong.Text),
                nam = int.Parse(txtngaycong.Text),
                noidung = txtnoidung.Text,
                thang = int.Parse(txtthang.Text)
            });

            DataTable dataTable = (DataTable)dataGridViewChamCong.DataSource;
            foreach (DataRow row in dataTable.Rows)
            {
                string so = DateTime.Now.ToString("HH_mm_ss_") + row[0].ToString();
                string manv = row[1].ToString();
                string ngaycong = row[2].ToString();
                string ngayphep = row[3].ToString();
                string ngaykhongphep = row[4].ToString();
                string tienphucap = row[5].ToString();
                string tienthuong = row[6].ToString();
                db.chitietbangccs.Add(new chitietbangcc() {
                    so = so,
                    manv = manv,
                    ngaycong = double.Parse(ngaycong),
                    ngayphep = double.Parse(ngayphep),
                    ngaykhongphep = double.Parse(ngaykhongphep),
                    tienphucap = double.Parse(tienphucap),
                    tienthuong = double.Parse(tienthuong),
                });
            }

            db.SaveChanges();

            dataGridViewChamCong.DataSource = null;
            txtso.Text
                = txtngaycong.Text
                = txtngaycong.Text
                = txtnoidung.Text
               = txtthang.Text = "";

            cbomabp.SelectedIndex = 0;

            MessageBox.Show("Lưu thành công!");
        }

        private void cbomabp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelContentBox_Paint(object sender, PaintEventArgs e)
        {
            var db = new ketoantienluongEntities();
            cbomabp.DisplayMember = "Tenbp";
            cbomabp.ValueMember = "Mabp";

            cbomabp.DataSource = db.dmbps.Select(item => item).ToList();
            cbomabp.Refresh();
        }
    }
}
