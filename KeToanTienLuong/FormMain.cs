using KeToanTienLuong.categoryForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HeThongForm heThongForm = new HeThongForm();
            heThongForm.Dock = DockStyle.Fill;
            this.panelParent.Controls.Clear();
            this.panelParent.Controls.Add(heThongForm);
            heThongForm.Show();
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStripMain.Items)
            {
                item.BackColor = SystemColors.Control;
            }

            // Đặt màu nền cho mục menu được chọn
            ToolStripMenuItem selectedMenuItem = e.ClickedItem as ToolStripMenuItem;
            selectedMenuItem.BackColor = Color.LightBlue;
        }

        private void aaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DanhMucForm f = new DanhMucForm();
            f.Dock = DockStyle.Fill;
            this.panelParent.Controls.Clear();
            this.panelParent.Controls.Add(f);
            f.Show();
        }

        private void thamSốLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThamSoLuong f = new ThamSoLuong();
            f.Dock = DockStyle.Fill;
            this.panelParent.Controls.Clear();
            this.panelParent.Controls.Add(f);
            f.Show();
        }

        private void chứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChungTuForm f = new ChungTuForm();
            f.Dock = DockStyle.Fill;
            this.panelParent.Controls.Clear();
            this.panelParent.Controls.Add(f);
            f.Show();
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhLuongForm f = new TinhLuongForm();
            f.Dock = DockStyle.Fill;
            this.panelParent.Controls.Clear();
            this.panelParent.Controls.Add(f);
            f.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoForm f = new BaoCaoForm();
            f.Dock = DockStyle.Fill;
            this.panelParent.Controls.Clear();
            this.panelParent.Controls.Add(f);
            f.Show();
        }

        private void panelParent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
