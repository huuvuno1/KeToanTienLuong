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
    public partial class DanhMucTaiKhoanForm : UserControl
    {
        public DanhMucTaiKhoanForm()
        {
            InitializeComponent();
        }

        private void DanhMucTaiKhoanForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();

            dgvdmtk.DataSource = db.dmtks.Select(p => p).ToList();
            dgvdmtk.Refresh();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            inpTenTk.Enabled = inpMaTk.Enabled = inpCapTk.Enabled = cbotkme.Enabled = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            db.dmtks.Add(new dmtk() {
                tkme = cbotkme.SelectedItem.ToString(),
                captk = int.Parse(inpCapTk.Text),
                matk = inpMaTk.Text,
                tentk = inpTenTk.Text,
            });
            db.SaveChanges();
            dgvdmtk.DataSource = db.dmtks.Select(p => p).ToList();
            dgvdmtk.Refresh();
            inpTenTk.Enabled = inpMaTk.Enabled = inpCapTk.Enabled = cbotkme.Enabled = false;
            inpTenTk.Text = inpMaTk.Text = inpCapTk.Text = cbotkme.Text = "";

        }
    }
}
