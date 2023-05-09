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
    }
}
