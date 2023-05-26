using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.tinhluongfrm
{
    public partial class BangLuongForm : UserControl
    {
        public BangLuongForm()
        {
            InitializeComponent();
        }

        private void dataGridViewBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getDataSource(int month, int year)
        {
            var db = new ketoantienluongEntities();
            var query = from b in db.dmnvs
                        join l in db.bangluongnhanviens on b.manv equals l.manv
                        where l.thang == month && l.nam == year
                        select new {
                            b.manv,
                            b.tenv,
                            b.ngaysinh,
                            l.nam,
                            l.thang,
                            l.noidung,
                            l.ngaycongcuathang,
                            ngaycongthucte = l.ngaycong,
                            l.tienluongcoban,
                            luongtheongaycong = l.tienluong,
                            l.phucapantrue,
                            l.tienthuong,
                            l.phucapkhac,
                            l.tienphat,
                            l.tienphucap,
                            l.tienbhxh,
                            l.tienbhtn,
                            l.tienbhyt,
                            l.giamtrucanhan,
                            l.giamtruphuthuoc,
                            l.tientruocthue,
                            l.tienthue,
                            l.tonggiamtru,
                            l.tongbaohiem,
                            l.tientamung,
                            l.tienthuclinh
                        };

            dataGridViewBangLuong.DataSource = query.ToList();
        }

        private void formload(object sender, EventArgs e)
        {
            comboBoxThang.SelectedItem = DateTime.Now.Month.ToString();
            comboBoxNam.SelectedItem = DateTime.Now.Year.ToString() ;
            getDataSource(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            //dataGridViewBangLuong.DataSource = new ketoantienluongEntities().laydsbangluong(int.Parse(inpThang.Text), int.Parse(inpNam.Text)).ToList();

            getDataSource(int.Parse(comboBoxThang.SelectedItem.ToString()), int.Parse(comboBoxNam.SelectedItem.ToString()));
        }
    }
}
