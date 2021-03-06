﻿using System;
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

        string sql;
        int count = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM ACCOUNT WHERE USERNAME='" + txbUsername.Text +
                    "' AND PASSWD='" + txbPassword.Text + "'";
                int result = Database.Instance.CheckUser(sql);
                DataTable table = Database.Instance.LoadData(sql);
                if (result == 1)
                {
                    this.Hide();
                    QuanLiDaoTao qldt = new QuanLiDaoTao();
                    Account.User.setUsername(table.Rows[0]["USERNAME"].ToString());
                    Account.User.setPasswd(table.Rows[0]["PASSWD"].ToString());
                    Account.User.setGrant(table.Rows[0]["GRANTUSER"].ToString());
                    Account.User.setDetail(table.Rows[0]["NOTE"].ToString());
                   
                    qldt.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, sai tài khoản hoặc mật khẩu", "Thông báo");
                    txbPassword.Clear();
                    count+=1;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            if (count == 3)
            {
                MessageBox.Show("Bạn đã đăng nhập sai quá số lần quy định!");
                Application.Exit();

            }        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
