using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QuanLiDaoTao
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        public string sql = "SELECT * FROM KHOA";
        int index;

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvLoadKhoa.DataSource = Database.Instance.LoadData(sql);
        }
        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaKhoa"] = txbMaKhoa.Text;
            newRow["TenKhoa"] = txbTenKhoa.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvLoadKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                DataTable table = Database.Instance.LoadData(sql);
                txbMaKhoa.Text = table.Rows[index]["MaKhoa"].ToString();
                txbTenKhoa.Text = table.Rows[index]["TenKhoa"].ToString();
            }
            
        }
    }
}
