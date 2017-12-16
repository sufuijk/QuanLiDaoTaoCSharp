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
    public partial class NganhDaoTao : Form
    {
        public NganhDaoTao()
        {
            InitializeComponent();
        }
        string sql = "SELECT * FROM Nganh_Daotao";
        int index;

        private void LoadData()
        {
            dgvNDT.DataSource = Database.Instance.LoadData(sql);
        }
        private void NganhDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnAddNDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaNganhDT"] = txbMaNDT.Text;
            newRow["TenNganhDT"] = txbTenNDT.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnEditNDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index]["MaNganhDT"] = txbMaNDT.Text;
            table.Rows[index]["TenNganhDT"] = txbTenNDT.Text;
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnDelNDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index].Delete();
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                txbMaNDT.Text = table.Rows[index]["MaNganhDT"].ToString();
                txbTenNDT.Text = table.Rows[index]["TenNganhDT"].ToString();
            }
        }
    }
}
