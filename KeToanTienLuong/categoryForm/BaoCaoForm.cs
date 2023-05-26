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
using System.Data.SqlClient;

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
            //rptBaocaoluong rpt = new rptBaocaoluong();
            //var db = new ketoantienluongEntities();
            //var data = db.laydsbangluong(DateTime.Now.Month, DateTime.Now.Year).ToList();
            ////datatable.Fill
            //DataTable dataTable = new DataTable();
            //using (var reader = ObjectReader.Create(data))
            //{
            //    dataTable.Load(reader);
            //}
            //rpt.SetDataSource(dataTable);
            //crystalReportViewer.ReportSource = rpt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rptThueTNCN rpt = new rptThueTNCN();
            SqlConnection sqlConnection = new SqlConnection(Util.Util.getConnectionString());
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = @"select b.manv, b.tenv, b.ngaysinh, l.nam, l.thang, l.giamtrucanhan, l.giamtruphuthuoc, l.tientruocthue, l.tienthue, l.tientruocthue  - 730000 as tienthunhaptinhthue, l.tonggiamtru, l.tienthuclinh
                                from  dmnv as b join bangluongnhanvien as l on b.manv = l.manv";
            var datatable = new DataTable();
            datatable.Load(cmd.ExecuteReader());
            rpt.SetDataSource(datatable);
            sqlConnection.Close();
            crystalReportViewer.ReportSource = rpt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rptBaoHiem rpt = new rptBaoHiem();
            SqlConnection sqlConnection = new SqlConnection(Util.Util.getConnectionString());
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = @"select * from  dmnv as b
                        join bangluongnhanvien as l on b.manv = l.manv";
            var datatable = new DataTable();
            datatable.Load(cmd.ExecuteReader());
            rpt.SetDataSource(datatable);
            sqlConnection.Close();
            crystalReportViewer.ReportSource = rpt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rptBaocaoluong rpt = new rptBaocaoluong();
            SqlConnection sqlConnection = new SqlConnection(Util.Util.getConnectionString());
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = @"select b.manv, b.tenv, ngaycongthucte = l.ngaycong, l.tienluongcoban, l.tienthuong, l.tienthue, l.tientamung, l.tienthuclinh
from  dmnv as b join bangluongnhanvien as l on b.manv = l.manv";
            var datatable = new DataTable();
            datatable.Load(cmd.ExecuteReader());
            rpt.SetDataSource(datatable);
            sqlConnection.Close();
            crystalReportViewer.ReportSource = rpt;
        }
    }
}
