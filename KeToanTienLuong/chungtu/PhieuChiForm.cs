using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace KeToanTienLuong.chungtu
{
    public partial class PhieuChiForm : UserControl
    {
        public PhieuChiForm()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            
            
            var db = new ketoantienluongEntities();
            db.phieuchis.Add(new phieuchi() {
                so= txtso.Text,
                ctlq= txtctlq.Text,
                manv =cbomanv.SelectedValue.ToString(),
                ngay = dtngay.Value,
                tkno = comboBoxTkNo.SelectedValue.ToString(),
                tkco = inpTkCo.Text
            });

            try
            {
                db.SaveChanges();
            } catch (Exception ee)
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

        private void addComboboxCell(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        private void pnDoiTuong_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PhieuChiForm_Load(object sender, EventArgs e)
        {
            cbomanv.DataSource = new ketoantienluongEntities().dmnvs.Select(p => p).ToList();
            cbomanv.DisplayMember = "tenv";
            cbomanv.ValueMember = "manv";

            var db = new ketoantienluongEntities();
            DataGridViewComboBoxColumn a = dgvchitietchungtu.Columns["tkno"] as DataGridViewComboBoxColumn;
            a.DataSource = db.dmtks.Select(p => p).ToList();

            foreach (DataGridViewRow row in dgvchitietchungtu.Rows)
            {
                row.Cells["tkco"].Value = "1111";
                row.Cells["tkco"].ReadOnly = true;
            }
        }

        private void test(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void ok(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["tkco"].Value = "Default Value";
        }

        private void kkk(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
