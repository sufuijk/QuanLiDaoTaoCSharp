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
    public partial class BacDaoTao : Form
    {
        public BacDaoTao()
        {
            InitializeComponent();
        }
        string sql = "SELECT * FROM BacDaoTao";
        int index;

        private void LoadData()
        {
            dgvLoadBDT.DataSource = Database.Instance.LoadData(sql);
        }
        private void BacDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddBDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaBacDT"] = txbMaBDT.Text;
            newRow["TenBacDT"] = txbTenBDT.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnEditBDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index]["MaBacDT"] = txbMaBDT.Text;
            table.Rows[index]["TenBacDT"] = txbTenBDT.Text;
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvLoadBDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                txbMaBDT.Text = table.Rows[index]["MaBacDT"].ToString();
                txbTenBDT.Text = table.Rows[index]["TenBacDT"].ToString();
            }
        }

        private void btnDelBDT_Click(object sender, EventArgs e)
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
    }
}
