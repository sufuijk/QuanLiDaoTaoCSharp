using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDaoTao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string sql = "SELECT * FROM ACCOUNT";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql += " WHERE USERNAME='" + txbUsername.Text + "' AND PASSWD='" + txbPassword.Text+"'";
            int result = Database.Instance.CheckUser(sql);
            if(result == 1)
            {
                this.Hide();
                QuanLiDaoTao qldt = new QuanLiDaoTao();
                qldt.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, sai tài khoản hoặc mật khẩu", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
