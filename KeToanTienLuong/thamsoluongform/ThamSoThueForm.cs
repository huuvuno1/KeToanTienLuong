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
            if (db.thamsothuetncns.Count() < 7)
            {
                var list = db.thamsothuetncns.ToList();
                db.thamsothuetncns.RemoveRange(list);

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 1,
                    mucthue = "1",
                    tientu = 0,
                    tienden = 5,
                    tyle = 5
                });

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 2,
                    mucthue = "2",
                    tientu = 5,
                    tienden = 10,
                    tyle = 10
                });

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 3,
                    mucthue = "3",
                    tientu = 10,
                    tienden = 18,
                    tyle = 15
                });

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 4,
                    mucthue = "4",
                    tientu = 18,
                    tienden = 32,
                    tyle = 20
                });

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 5,
                    mucthue = "5",
                    tientu = 32,
                    tienden = 52,
                    tyle = 25
                });

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 6,
                    mucthue = "6",
                    tientu = 52,
                    tienden = 80,
                    tyle = 30
                });

                db.thamsothuetncns.Add(new thamsothuetncn() {
                    muc = 7,
                    mucthue = "7",
                    tientu = 80,
                    tienden = 0,
                    tyle = 35
                });
                 db.SaveChanges();
            }
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = db.thamsothuetncns.ToList().Select(p => new { 
                muc = p.muc,
                mucthue = p.mucthue,
                tienden = p.tienden == 0 ? "" : p.tienden + " triệu đồng",
                tientu = (p.muc == 7 ? "Trên " : "") + p.tientu + " triệu đồng",
                tyle = p.tyle + "%",
            }).ToList();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
