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
        public int GaintUser;
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLoadGiangvien.DataSource = Database.Instance.LoadData(sql);
            //Phân quyền ở đây 
            //1 là administrator
            //khác là user 
            if (GaintUser != 1)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage5);
            }
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

        private void btnDetailDT_Click(object sender, EventArgs e)
        {
            DanToc dantoc = new DanToc();
            dantoc.ShowDialog();
        }

        private void btnDetailBDT_Click(object sender, EventArgs e)
        {
            BacDaoTao bacdaotao = new BacDaoTao();
            bacdaotao.ShowDialog();
        }

        private void btnDetailNoiDT_Click(object sender, EventArgs e)
        {
            NoiDaoTao noidaotao = new NoiDaoTao();
            noidaotao.ShowDialog();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM ACCOUNT";
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["USERNAME"] = txbUsername.Text;
            newRow["PASSWD"] = txbPassword.Text;
            newRow["GAINT"] = int.Parse(txbGaint.Text);
            newRow["NOTE"] = txbNote.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
        }
    }
}
