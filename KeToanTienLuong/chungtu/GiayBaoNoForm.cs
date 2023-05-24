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
    public partial class GiayBaoNoForm : UserControl
    {
        public int _them = 0;
        LopDungChung kn = new LopDungChung();
        public string _Tenbang = "phieuchi";
        public string _Tenbangchitiet = "chitietphieu";
        public string _so = "";
        DataTable dtct = new DataTable();

        public GiayBaoNoForm()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void dgvchitietchungtu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool kiemtradulieu()
        {
            if (txtso.Text.Trim() == "")
            {
                MessageBox.Show("số không được để trống");
                txtso.Select();
                return false;
            }
            else return true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

            var db = new ketoantienluongEntities();
            db.giaybaonoes.Add(new giaybaono() {
                so = txtso.Text,
                ctlq = txtctlq.Text,
                manv = cbomanv.SelectedValue.ToString(),
                ngay = dtngay.Value,
                manh = cbomanh.SelectedValue.ToString(),
                tien = decimal.Parse(inpTien.Text),
                tkno = comboBoxTkNo.SelectedValue.ToString(),
                tkco = inpTkCo.Text,
            }); ; ;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ee)
            {
                MessageBox.Show($"* Đã có lỗi xảy ra, có thể bị trùng mã phiếu!");
                return;
            };
            MessageBox.Show($"* Lưu phiếu {txtso.Text} thành công!");

            txtctlq.Text = txtnoidung.Text = txtso.Text = "";
            dtngay.Value = DateTime.Now;
            cbomanh.SelectedIndex = 0;
            cbomanv.SelectedIndex = 0;
            dgvchitietchungtu.Rows.Clear();
        }

        private void GiayBaoNoForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            cbomanh.DataSource = db.dmnhs.Select(p => p).ToList();
            cbomanh.DisplayMember = "stk";
            cbomanh.ValueMember = "so";
            cbomanh.Format += ComboBox1_Format;

            cbomanv.DataSource = db.dmnvs.Select(p => p).ToList();
            cbomanv.DisplayMember = "tenv";
            cbomanv.ValueMember = "manv";

            DataGridViewComboBoxColumn a = dgvchitietchungtu.Columns["tkno"] as DataGridViewComboBoxColumn;
            a.DataSource = db.dmtks.Select(p => p).ToList();

            comboBoxTkNo.DataSource = db.dmtks.Select(p => p).ToList();
            comboBoxTkNo.DisplayMember = "matk";
            comboBoxTkNo.ValueMember = "matk";

            foreach (DataGridViewRow row in dgvchitietchungtu.Rows)
            {
                row.Cells["tkco"].Value = "1112";
                row.Cells["tkco"].ReadOnly = true;
            }
        }

        private void ComboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            // Định dạng lại giá trị hiển thị cho từng mục trong ComboBox
            if (e.ListItem is dmnh value)
            {
                // Tùy chỉnh định dạng ở đây, ví dụ: thêm tiền tố vào tên
                e.Value = value.stk.Trim() + " - " + value.tennh;
            }
        }

        private void addComboboxCell(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inpTkCo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
