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
    public partial class ThamSoBaoHiem : UserControl
    {
        public ThamSoBaoHiem()
        {
            InitializeComponent();
        }

        private void ThamSoBaoHiem_Load(object sender, EventArgs e)
        {
            var db = new ketoantienluongEntities();
            if (db.thamsoluongs.Count() < 5)
            {
                var list = db.thamsoluongs.ToList();
                db.thamsoluongs.RemoveRange(list);

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHTN",
                    tents = "Bảo hiểm thất nghiệp nhân viên đóng",
                    noidung = "Bảo hiểm thất nghiệp",
                    tyle = 1
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHTN_CTY",
                    tents = "Bảo hiểm thất nghiệp công ty đóng",
                    noidung = "Bảo hiểm thất nghiệp",
                    tyle = 1
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHXH",
                    tents = "Bảo hiểm xã hội nhân viên đóng",
                    noidung = "Bảo hiểm xã hội",
                    tyle = 8
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHXH_CTY",
                    tents = "Bảo hiểm xã hội công ty đóng",
                    noidung = "Bảo hiểm xã hội",
                    tyle = 17.5
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHYT",
                    tents = "Bảo hiểm y tế nhân viên đóng",
                    noidung = "Bảo hiểm y tế",
                    tyle = 1.5
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHYT_CTY",
                    tents = "Bảo hiểm y tế công ty đóng",
                    noidung = "Bảo hiểm y tế",
                    tyle = 3
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "BHCD_CTY",
                    tents = "Bảo hiểm công đoàn công ty đóng",
                    noidung = "Bảo hiểm công đoàn",
                    tyle = 2
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "GTCN",
                    tents = "Giảm trừ cá nhân",
                    noidung = "Giảm trừ bản thân khi tính thuế",
                    tyle = 11000000
                });

                db.thamsoluongs.Add(new thamsoluong() {
                    mats = "GTPT",
                    tents = "Giảm trừ phụ thuộc",
                    noidung = "Giảm trừ tiền tính thuế",
                    tyle = 4400000
                });
                db.SaveChanges();
            }

            dataGridView.DataSource = db.thamsoluongs.Select(p => p).ToList();
            dataGridView.Refresh();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
