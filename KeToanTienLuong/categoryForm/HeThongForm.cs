using KeToanTienLuong.hethongform;
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
    public partial class HeThongForm : UserControl
    {
        public HeThongForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button3.BackColor = Color.White;
            button4.BackColor = SystemColors.Control;
            panelContent.Focus();

            SaoLuuForm f = new SaoLuuForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            panelContent.Focus();

            NguoiDungForm f = new NguoiDungForm();
            f.Dock = DockStyle.Fill;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = Color.White;
            panelContent.Focus();

            SaoLuuForm f = new SaoLuuForm();
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
