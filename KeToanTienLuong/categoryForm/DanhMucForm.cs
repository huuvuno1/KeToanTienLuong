using KeToanTienLuong.danhmucform;
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
    public partial class DanhMucForm : UserControl
    {
        public DanhMucForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonBoPhan, buttonChucVu, buttonNhanVien);
            
            BoPhanForm f = new BoPhanForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonNhanVien, buttonChucVu, buttonBoPhan);

            NhanVienForm f = new NhanVienForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Util.Util.changeBackground(buttonChucVu, buttonNhanVien, buttonBoPhan);
            ChucVuForm f = new ChucVuForm();
            f.Dock = DockStyle.Top;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(f);
            f.Show();
        }
    }
}
