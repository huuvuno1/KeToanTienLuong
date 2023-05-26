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
            cbomanv.DataSource = new ketoantienluongEntities().dmnvs.ToList().Where(p => p.trangthai == 1).ToList();
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
            var db = new ketoantienluongEntities();

            List<chitietphieuketoan> list = new List<chitietphieuketoan>();
            var so = "PKT_" + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss");

            int i = 0;
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
                    so = so,
                    tkno = rowData[0],
                    tkco = rowData[1],
                    noidung = rowData[2],
                    tien = double.Parse(tien),
                });

                if (i == 0)
                {
                    db.socais.Add(new socai() {
                        sophieu = so,
                        diengiai = txtnoidung.Text,
                        ngaytao = DateTime.Now,
                        tkdu = rowData[0],
                    });
                } else
                {
                    db.socais.Add(new socai() {
                        diengiai = txtnoidung.Text,
                        tkdu = rowData[0],
                    });
                }

                i++;
            }


            db.phieuketoans.Add(new phieuketoan() {
                so = so,
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

        private void pnDoiTuong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
