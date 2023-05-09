using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.hethongform
{
    public partial class NguoiDungForm : UserControl
    {
        public NguoiDungForm()
        {
            InitializeComponent();

            
            
        }

        private void dataGridViewNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNguoiDung_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void NguoiDungForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            dataGridViewNguoiDung.DataSource = db.nguoidungs.Select(p => p).ToList();
            dataGridViewNguoiDung.Refresh();
        }
    }
}
