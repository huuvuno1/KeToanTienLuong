﻿using DocumentFormat.OpenXml.Packaging;
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
            inpThang.Text = DateTime.Now.ToString("MM");
            inpNam.Text = DateTime.Now.ToString("yyyy");

            //UpdateBangLuong(null);
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
            var list = new List<chitietbangcc>();

            DataTable dataTable = (DataTable)dataGridViewChamCong.DataSource;
            foreach (DataRow row in dataTable.Rows)
            {
                string so = txtso.Text;
                string manv = row[1].ToString();
                string ngaycong = row[2].ToString();
                string ngayphep = row[3].ToString();
                string ngaykhongphep = row[4].ToString();
                string tienphucap = row[5].ToString();
                string tienthuong = row[6].ToString();
                list.Add(new chitietbangcc() {
                    so = so,
                    manv = manv,
                    ngaycong = double.Parse(ngaycong),
                    ngayphep = double.Parse(ngayphep),
                    ngaykhongphep = double.Parse(ngaykhongphep),
                    tienphucap = double.Parse(tienphucap),
                    tienthuong = double.Parse(tienthuong),
                });
            }

            var db = new ketoantienluongEntities();

            int thang = int.Parse(inpThang.Text);
            int nam = int.Parse(inpNam.Text);
            string mabp = cbomabp.SelectedValue.ToString();

            // delete old value in same month
            var oldValue = db.bangccs.Where(x => x.thang == thang
             && x.nam == nam && x.mabp == mabp);

            db.bangccs.RemoveRange(oldValue);
            db.SaveChanges();

            var data = new bangcc() {
                so = txtso.Text,
                mabp = cbomabp.SelectedValue.ToString(),
                ngaycong = int.Parse(txtngaycong.Text),
                nam = int.Parse(txtnam.Text),
                noidung = txtnoidung.Text,
                thang = int.Parse(txtthang.Text),
                chitietbangccs = list
            };
            db.bangccs.Add(data);
            db.SaveChanges();

            UpdateBangLuong(db, txtso.Text);
            dataGridViewChamCong.DataSource = null;
            txtso.Text
                = txtngaycong.Text
                = txtngaycong.Text
                = txtnoidung.Text
               = txtthang.Text = "";

            cbomabp.SelectedIndex = 0;

            // update bang luong

            MessageBox.Show("Lưu thành công!");

            
        }

        private void UpdateBangLuong(ketoantienluongEntities db, string so)
        {
            var list = new List<bangluongnhanvien>();
            int thang = int.Parse(inpThang.Text);
            int nam = int.Parse(inpNam.Text);
            //var bangcc = db.bangccs.Where(p => p.nam == nam && p.thang == thang);
            var data = db.bangccs.Find(so);
            data.chitietbangccs.ToList().ForEach((ctbcc) => {
                var nv = db.dmnvs.Find(ctbcc.manv);
                var lcb = nv.luongcoban;
                data.bangluongnhanviens.Add(new bangluongnhanvien() {
                    bhtn = 0.01m,
                    bhxh = 0.08m,
                    bhyt = 0.015m,
                    tienbhtn = lcb * 0.08m,
                    tienbhyt = lcb * 0.01m,
                    tienbhxh = lcb * 0.015m,
                    tiencongdoan = lcb * 0.01m,
                    tienluongcoban = lcb,
                    tienbhxhctytra = lcb * 1.75m,
                    tienbhytctytra = lcb * 0.03m,
                    tienbtntnctytra = lcb * 0.01m,
                    phucapantrue = 750000,
                    phucapkhac = 300000,
                    tienluong = lcb / data.ngaycong * decimal.Parse(ctbcc.ngaycong.ToString()),
                    giamtrucanhan = 11000000,
                    giamtruphuthuoc = 4400000 * nv.songuoiphuthuoc
                });
            });

            db.SaveChanges();
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

        private void buttonXem_Click(object sender, EventArgs e)
        {
            inpThang.Text = DateTime.Now.ToString("MM");
            inpNam.Text = DateTime.Now.ToString("yyyy");
            buttonXem.BackColor = SystemColors.ControlDark;
            buttonThem.BackColor = System.Drawing.Color.White;

            labelNam1.Visible = labelThang1.Visible = labelSo.Visible =
                labelNgayCong.Visible = labelBoPhan.Visible = labelNoiDung.Visible =
                txtso.Visible = txtthang.Visible = txtnam.Visible =
                txtngaycong.Visible = cbomabp.Visible = txtnoidung.Visible = false;

            labelNam.Visible = labelThang.Visible = inpThang.Visible = inpNam.Visible = buttonLookup.Visible = buttonLookup.Visible = true;

            dataGridViewChamCong.Visible = false;
            dataGridViewBangCong.Visible = true;

            var db = new ketoantienluongEntities();
            int t = int.Parse( inpThang.Text);
            int n = int.Parse(inpNam.Text);
            var query = from bcc in db.bangccs
                        join ctbcc in db.chitietbangccs on bcc.so equals ctbcc.so
                        where bcc.thang == t && bcc.nam == n
                        select new {
                            ctbcc
                        };
            dataGridViewBangCong.DataSource = query.Select(p => p.ctbcc).ToList();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            buttonXem.BackColor = System.Drawing.Color.White;
            buttonThem.BackColor =  SystemColors.ControlDark;

            dataGridViewChamCong.Visible = true;
            dataGridViewBangCong.Visible = false;

            labelNam1.Visible = labelThang1.Visible = labelSo.Visible =
                labelNgayCong.Visible = labelBoPhan.Visible = labelNoiDung.Visible =
                txtso.Visible = txtthang.Visible = txtnam.Visible =
                txtngaycong.Visible = cbomabp.Visible = txtnoidung.Visible = true;

            labelNam.Visible = labelThang.Visible = inpThang.Visible = inpNam.Visible = false;
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            int t = int.Parse(inpThang.Text);
            int n = int.Parse(inpNam.Text);
            var query = from bcc in db.bangccs
                        join ctbcc in db.chitietbangccs on bcc.so equals ctbcc.so
                        where bcc.thang == t && bcc.nam == n
                        select new {
                            ctbcc
                        };
            dataGridViewBangCong.DataSource = query.Select(p => p.ctbcc).ToList();
        }
    }
}
