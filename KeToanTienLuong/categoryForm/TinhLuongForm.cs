using KeToanTienLuong.tinhluongfrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.categoryForm
{
    public partial class TinhLuongForm : UserControl
    {
        public TinhLuongForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(btnChamCong, btnThueTNCN, btnTinhLuong);

            ChamCongForm f = new ChamCongForm();
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
