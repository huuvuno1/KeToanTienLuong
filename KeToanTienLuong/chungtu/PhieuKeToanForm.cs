using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.chungtu
{
    public partial class PhieuKeToanForm : UserControl
    {
        public PhieuKeToanForm()
        {
            InitializeComponent();
        }

        private void PhieuKeToanForm_Load(object sender, EventArgs e)
        {
            cbomanv.DataSource = new ketoantienluongEntities().dmnvs.Select(p => p).ToList();
            cbomanv.DisplayMember = "tenv";
            cbomanv.ValueMember = "manv";

            var db = new ketoantienluongEntities();
            DataGridViewComboBoxColumn a = dgvchitietchungtu.Columns["tkno"] as DataGridViewComboBoxColumn;
            a.DataSource = db.dmtks.Select(p => p).ToList();

            DataGridViewComboBoxColumn b = dgvchitietchungtu.Columns["tkco"] as DataGridViewComboBoxColumn;
            b.DataSource = db.dmtks.Select(p => p).ToList();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            List<chitietphieuketoan> list = new List<chitietphieuketoan>();

            foreach (DataGridViewRow clickedRow in dgvchitietchungtu.Rows)
            {
                if (clickedRow.IsNewRow)
                    break;
                // Lấy dữ liệu của cả hàng
                string[] rowData = clickedRow.Cells.Cast<DataGridViewCell>()
                                                  .Select(cell => cell.Value?.ToString())
                                                  .ToArray();

                string tien = string.IsNullOrEmpty(rowData[3]) ? "0" : rowData[3];
                list.Add(new chitietphieuketoan() {
                    so = txtso.Text,
                    tkno = rowData[0],
                    tkco = rowData[1],
                    noidung = rowData[2],
                    tien = double.Parse(tien),

                });
            }


            var db = new ketoantienluongEntities();
            db.phieuketoans.Add(new phieuketoan() {
                so = txtso.Text,
                ctlq = txtctlq.Text,
                manv = cbomanv.SelectedValue.ToString(),
                ngay = dtngay.Value,
                chitietphieuketoans = list,
            });

            try
            {
                db.SaveChanges();
            }
            catch (Exception ee)
            {
                labelMessage.Text = $"* Lỗi: mã phiếu đã tồn tại";
                return;
            };
            MessageBox.Show($"* Lưu phiếu {txtso.Text} thành công!");

            txtctlq.Text = txtnoidung.Text = txtso.Text = "";
            cbomanv.SelectedIndex = 0;
            dgvchitietchungtu.Rows.Clear();

            //labelMessage.Text = $"* Lưu phiếu {txtso.Text} thành công!";

        }
    }
}
