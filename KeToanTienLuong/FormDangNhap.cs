using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong
{
    public partial class FormDangNhap : Form
    {
        string filePath = Path.Combine(Application.StartupPath, "save_password.txt");
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                inpUsername.Text = content.Split(new string[] { "__" }, StringSplitOptions.None)[0];
                inpMatKhau.Text  = content.Split(new string[] { "__" }, StringSplitOptions.None)[1] ;
                checkboxSavePass.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkboxSavePass.Checked)
            {
                File.WriteAllText(filePath, $"{inpUsername.Text}__{inpMatKhau.Text}");
            } else
            {
                File.Delete(filePath);
            }
            var db = new ketoantienluongEntities();
            var list = db.nguoidungs.Where(p => p.tendangnhap == inpUsername.Text && p.matkhau == inpMatKhau.Text).ToList();
            if (list.Count > 0)
            {
                Util.Util.user_login = list[0];
                this.Close();
            } else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
