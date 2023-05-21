using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.tinhluongfrm
{
    public partial class BangLuongForm : UserControl
    {
        public BangLuongForm()
        {
            InitializeComponent();
        }

        private void dataGridViewBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formload(object sender, EventArgs e)
        {
            inpThang.Text = DateTime.Now.ToString("MM");
            inpNam.Text = DateTime.Now.ToString("yyyy");
            dataGridViewBangLuong.DataSource = new ketoantienluongEntities().laydsbangluong(int.Parse(inpThang.Text), int.Parse(inpNam.Text));
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            dataGridViewBangLuong.DataSource = new ketoantienluongEntities().laydsbangluong(int.Parse(inpThang.Text), int.Parse(inpNam.Text)).ToList();
        }
    }
}
