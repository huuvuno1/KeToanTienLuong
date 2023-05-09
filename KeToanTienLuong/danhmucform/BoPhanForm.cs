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
    }
}
