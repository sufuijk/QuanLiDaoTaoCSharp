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
    public partial class QuanLiDaoTao : Form
    {
        public QuanLiDaoTao()
        {
            InitializeComponent();
        }
        private string sql = "SELECT * FROM GiangVien";

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLoadGiangvien.DataSource = Database.Instance.LoadData(sql);
        }

        private void btnDetailKhoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDetailBM_Click(object sender, EventArgs e)
        {
            BoMon bomon = new BoMon();
            bomon.ShowDialog();
        }

        private void btnDetailNDT_Click(object sender, EventArgs e)
        {
            NganhDaoTao nghanhdaotao = new NganhDaoTao();
            nghanhdaotao.ShowDialog();
        }

        private void QuanLiDaoTao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
