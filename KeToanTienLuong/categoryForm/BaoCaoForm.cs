using KeToanTienLuong.report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework.Utilities;
using FastMember;

namespace KeToanTienLuong.categoryForm
{
    public partial class BaoCaoForm : UserControl
    {
        public BaoCaoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rptBaocaoluong rpt = new rptBaocaoluong();
            var db = new ketoantienluongEntities();
            var data = db.laydsbangluong(DateTime.Now.Month, DateTime.Now.Year).ToList();
            //datatable.Fill
            DataTable dataTable = new DataTable();
            using (var reader = ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }
            rpt.SetDataSource(dataTable);
            crystalReportViewer.ReportSource = rpt;
        }
    }
}
