using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.thamsoluongform
{
    public partial class ThamSoThueForm : UserControl
    {
        public ThamSoThueForm()
        {
            InitializeComponent();
        }

        private void ThamSoThueForm_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();

            dataGridView.DataSource = db.thamsothuetncns.Select(p => p).ToList();
            dataGridView.Refresh();
        }
    }
}
