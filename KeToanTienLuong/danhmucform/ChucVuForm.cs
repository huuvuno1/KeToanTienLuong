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
    public partial class ChucVuForm : UserControl
    {
        public ChucVuForm()
        {
            InitializeComponent();
        }

        private void ChucVuForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();

            dataGridView.DataSource = db.dmcvs.Select(p => p).ToList();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            inpMaCv.Enabled = inpMoTa.Enabled = inpTen.Enabled = true;
            buttonThem.Enabled = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.dmcvs.Add(new dmcv() {
                macv = inpMaCv.Text,
                mota = inpMoTa.Text,
                tencv = inpTen.Text
            }) ;

            db.SaveChanges();

            dataGridView.DataSource = db.dmcvs.Select(p => p).ToList();

            MessageBox.Show("Lưu thành công!");
            inpMaCv.Text = inpMoTa.Text = inpTen.Text = "";
            inpMaCv.Enabled = inpMoTa.Enabled = inpTen.Enabled = false;
            buttonThem.Enabled = true;
        }
    }
}
