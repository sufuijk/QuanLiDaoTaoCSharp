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
    public partial class DanToc : Form
    {
        public DanToc()
        {
            InitializeComponent();
        }
        string sql = "SELECT * FROM Dantoc";
        int index;
        private void LoadData()
        {
            dgvDT.DataSource = Database.Instance.LoadData(sql);
        }
        private void DanToc_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void dgvDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql);
            if(index >= 0)
            {
                txbMaDT.Text = table.Rows[index]["MaDanToc"].ToString();
                txbTenDT.Text = table.Rows[index]["TenDanToc"].ToString();
            }
        }

        private void btnAddDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaDanToc"] = txbMaDT.Text;
            newRow["TenDanToc"] = txbTenDT.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnEditDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index]["MaDanToc"] = txbMaDT.Text;
            table.Rows[index]["TenDanToc"] = txbTenDT.Text;
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnDelDT_Click(object sender, EventArgs e)
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
