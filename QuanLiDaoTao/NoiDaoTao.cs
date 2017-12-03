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
    public partial class NoiDaoTao : Form
    {
        public NoiDaoTao()
        {
            InitializeComponent();
        }
        string sql = "SELECT * FROM NOIDAOTAO";
        int index;

        private void LoadData()
        {
            dgvLoadNoiDT.DataSource = Database.Instance.LoadData(sql);
        }

        private void NoiDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddNoiDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaNoiDT"] = txbMaNoiDT.Text;
            newRow["TenNoiDT"] = txbTenNoiDT.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvLoadNoiDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                txbMaNoiDT.Text = table.Rows[index]["MaNoiDT"].ToString();
                txbTenNoiDT.Text = table.Rows[index]["TenNoiDT"].ToString();
            }
        }

        private void btnEditNoiDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index]["MaNoiDT"] = txbMaNoiDT.Text;
            table.Rows[index]["TenNoiDT"] = txbTenNoiDT.Text;
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnDelNoiDT_Click(object sender, EventArgs e)
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
