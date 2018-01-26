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
    public partial class HinhThucDaoTao : Form
    {
        public HinhThucDaoTao()
        {
            InitializeComponent();
        }

        string sql = "SELECT * FROM HINHTHUC_DAOTAO";
        int index;

        public void LoadData()
        {
            dgvLoadHTDT.DataSource = Database.Instance.LoadData(sql);
        }

        private void btnAddHTDT_Click(object sender, EventArgs e)
        {
            DataTable table =  Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaHTDT"] = txbMaHTDT.Text;
            newRow["TenHTDT"] = txbTenHTDT.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void HinhThucDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLoadHTDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                txbMaHTDT.Text = table.Rows[index]["MaHTDT"].ToString();
                txbTenHTDT.Text = table.Rows[index]["TenHTDT"].ToString();
            }
        }

        private void btnEditHTDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                table.Rows[index]["MaHTDT"] = txbMaHTDT.Text;
                table.Rows[index]["TenHTDT"] = txbTenHTDT.Text;
                Database.Instance.Update(table);
                LoadData();
            }else
            {
                MessageBox.Show("Chọn dòng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelHTDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                
                table.Rows[index].Delete();
                Database.Instance.Update(table);
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
