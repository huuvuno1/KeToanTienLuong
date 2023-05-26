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

        private void UpdateBangLuong()
        {
            var db = new ketoantienluongEntities();
            try
            {
                var list = new List<bangluongnhanvien>();
                int thang = int.Parse(comboBoxThang.SelectedItem.ToString());
                int nam = int.Parse(comboBoxNam.SelectedItem.ToString());
                //var bangcc = db.bangccs.Where(p => p.nam == nam && p.thang == thang);
                var data = db.bangccs.FirstOrDefault(p => p.thang == thang && p.nam == nam);

                if (data == null)
                    return;

                var chitietbang = db.chitietbangccs.ToList().Where(p => p.so.Trim() == data.so.Trim()).ToList();

                chitietbang.ToList().ForEach((ctbcc) => {
                    var ngaycongthangcuabophan = data.ngaycong;
                    var nv = db.dmnvs.Find(ctbcc.manv);
                    var lcb = nv.luongcoban;
                    var tientheongaycong = floor(lcb / data.ngaycong * decimal.Parse(ctbcc.ngaycong.ToString()));
                    var congthucte = ngaycongthangcuabophan - ctbcc.ngaykhongphep + ctbcc.ngayphep;
                    var luongngoaigio = floor(Convert.ToDecimal(ctbcc.sogiotangca) * (nv.luongcoban / Convert.ToDecimal((ngaycongthangcuabophan * 8).ToString())) * 1.5m);
                    decimal tientruocthue = (decimal)(tientheongaycong + 750000m + ctbcc.tienphucap + ctbcc.tienthuong - ctbcc.tienphat + luongngoaigio);
                    decimal tienthue = Util.Util.CalculatePersonalIncomeTax((decimal)(tientruocthue - 11000000 - nv.songuoiphuthuoc * 4400000));

                    var x = db.phieuchis.ToList();
                    // tam ung
                    var phieuchi = db.phieuchis.ToList().Where(p => p.tkno.Trim() == "3341" && p.ngay.Value.Month == thang && p.ngay.Value.Year == nam && p.manv.Trim() == nv.manv.Trim()).ToList();
                    decimal tamung = phieuchi.Aggregate(0m, (prev, curr) => (decimal)(prev + curr.tien));

                    var giaybaono = db.giaybaonoes.ToList().Where(p => p.tkno.Trim() == "3341" && p.ngay.Value.Month == thang && p.ngay.Value.Year == nam && p.manv.Trim() == nv.manv.Trim()).ToList();
                    tamung += giaybaono.Aggregate(0m, (prev, curr) => (decimal)(prev + curr.tien));


                    var bl = db.bangluongnhanviens.FirstOrDefault(p => p.thang == thang && p.nam == nam && p.manv == nv.manv);


                    bl.tienluong = tientheongaycong;
                    bl.tientruocthue = tientruocthue;
                    bl.tienthue = tienthue;
                    bl.tientamung = tamung;
                    bl.tienthuclinh = tientruocthue - tamung - tienthue - (lcb * 0.105m);

                    db.SaveChanges();
                });

                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private decimal floor(decimal? a)
        {
            return Math.Round((decimal)a);
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            //dataGridViewBangLuong.DataSource = new ketoantienluongEntities().laydsbangluong(int.Parse(inpThang.Text), int.Parse(inpNam.Text)).ToList();

            getDataSource(int.Parse(comboBoxThang.SelectedItem.ToString()), int.Parse(comboBoxNam.SelectedItem.ToString()));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateBangLuong();
            getDataSource(int.Parse(comboBoxThang.SelectedItem.ToString()), int.Parse(comboBoxNam.SelectedItem.ToString()));
        }
    }
}
