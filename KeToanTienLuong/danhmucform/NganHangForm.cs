using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.danhmucform
{
    public partial class NganHangForm : UserControl
    {
        public NganHangForm()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            inpChiNhanh.Enabled = inpMa.Enabled = inpStk.Enabled = inpTen.Enabled = true;
            buttonThem.Enabled = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.dmnhs.Add(new dmnh() {
                so = inpMa.Text,
                chinhanh = inpChiNhanh.Text,
                tennh = inpTen.Text,
                stk = inpStk.Text
            });;

            db.SaveChanges();
            MessageBox.Show("Lưu thành công!");

            dataGridView.DataSource = db.dmnhs.Select(p => p).ToList();
            inpChiNhanh.Enabled = inpMa.Enabled = inpStk.Enabled = inpTen.Enabled = false;
            inpChiNhanh.Text = inpMa.Text = inpStk.Text = inpTen.Text = "";
            buttonThem.Enabled = true;
        }

        private void NganHangForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            dataGridView.DataSource = db.dmnhs.Select(p => p).ToList();
        }
    }
}
