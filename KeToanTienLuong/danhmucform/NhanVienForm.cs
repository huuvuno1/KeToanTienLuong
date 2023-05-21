using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.danhmucform
{
    public partial class NhanVienForm : UserControl
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();

            dataGridView.DataSource = db.dmnvs.Select(p => p).ToList();


            comboBoxDMBP.DataSource = db.dmbps.Select(p => p).ToList();
            comboBoxDMBP.DisplayMember = "Tenbp";
            comboBoxDMBP.ValueMember = "Mabp";

            comboBoxChucVu.DataSource = db.dmcvs.Select(p => p).ToList();
            comboBoxChucVu.DisplayMember = "tencv";
            comboBoxChucVu.ValueMember = "macv";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            inpBangCap.Enabled = inpDiaChi.Enabled = inpLuongCoban.Enabled = inpMa.Enabled = inpMaSoThue.Enabled = inpNgaySinh.Enabled = inpTen.Enabled = inpTrinhDo.Enabled = comboBoxChucVu.Enabled = comboBoxDMBP.Enabled = inpPhuThuoc.Enabled = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.dmnvs.Add(new dmnv() {
                bangcap = inpBangCap.Text,
                diachi = inpDiaChi.Text,
                manv = inpLuongCoban.Text,
                masothue = inpMaSoThue.Text,
                ngaysinh = DateTime.ParseExact(inpNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                tenv = inpTen.Text,
                trinhdo = inpTrinhDo.Text,
                macv = comboBoxChucVu.SelectedValue.ToString(),
                mabp = comboBoxDMBP.SelectedValue.ToString(),
                songuoiphuthuoc = int.Parse(inpPhuThuoc.Text),
                luongcoban = decimal.Parse(inpLuongCoban.Text),
            });

            db.SaveChanges();
            MessageBox.Show("Lưu thành công!");


            dataGridView.DataSource = db.dmnvs.Select(p => p).ToList();
            inpBangCap.Text = inpDiaChi.Text = inpLuongCoban.Text = inpMa.Text = inpMaSoThue.Text
                = inpNgaySinh.Text = inpTen.Text = inpTrinhDo.Text = inpPhuThuoc.Text = "";
            comboBoxChucVu.SelectedIndex = comboBoxDMBP.SelectedIndex = 0;

            inpBangCap.Enabled = inpPhuThuoc.Enabled = inpDiaChi.Enabled = inpLuongCoban.Enabled = inpMa.Enabled = inpMaSoThue.Enabled = inpNgaySinh.Enabled = inpTen.Enabled = inpTrinhDo.Enabled = comboBoxChucVu.Enabled = comboBoxDMBP.Enabled = false;
        }

        private void comboBoxDMBP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
