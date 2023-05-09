using KeToanTienLuong.thamsoluongform;
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
    public partial class ThamSoLuongForm : UserControl
    {
        public ThamSoLuongForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonLuong, buttonTNCN);
            ThamSoBaoHiem f = new ThamSoBaoHiem();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonTNCN, buttonLuong);

            ThamSoThueForm f = new ThamSoThueForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
