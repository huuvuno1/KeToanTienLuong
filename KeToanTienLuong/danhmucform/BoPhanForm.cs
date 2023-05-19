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
    public partial class BoPhanForm : UserControl
    {
        public BoPhanForm()
        {
            InitializeComponent();
        }

        private void BoPhanForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
           
            dataGridViewBoPhan.DataSource = db.dmbps.Select(p => p).ToList();
            dataGridViewBoPhan.Refresh();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            inpDiaChi.Enabled = inpHotline.Enabled = inpMa.Enabled = inpTenBoPhan.Enabled = true;
            buttonThem.Enabled = false;
            

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.dmbps.Add(new dmbp() {
                Mabp = inpMa.Text,
                diachi = inpDiaChi.Text,
                sdt = inpHotline.Text,
                Tenbp = inpTenBoPhan.Text
            }); 

            db.SaveChanges();
            dataGridViewBoPhan.DataSource = db.dmbps.Select(p => p).ToList();
            inpDiaChi.Text = inpHotline.Text = inpMa.Text = inpTenBoPhan.Text = "";

            MessageBox.Show("Lưu thành công!");
            inpDiaChi.Enabled = inpHotline.Enabled = inpMa.Enabled = inpTenBoPhan.Enabled = false;
            buttonThem.Enabled = true;
        }
    }
}
