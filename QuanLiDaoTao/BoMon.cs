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
    public partial class BoMon : Form
    {
        public BoMon()
        {
            InitializeComponent();
        }
        string sql = "SELECT * FROM Bomon";
        string sql1 = "SELECT * FROM Khoa";

        int index;

        private void button1_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.ShowDialog();
        }
        private void LoadData()
        {
            dgvBM.DataSource = Database.Instance.LoadData(sql);
        }
        private void LoadCombox()
        {
            cbxKhoa.DataSource = Database.Instance.LoadData(sql1);
            cbxKhoa.ValueMember = "MaKhoa";
            cbxKhoa.DisplayMember = "TenKhoa";
        }
        private void BoMon_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombox();
        }

        private void btnAddBM_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaBM"] = txbMaBM.Text;
            newRow["TenBM"] = txbTenBM.Text;
            newRow["MaKhoa"] = cbxKhoa.SelectedValue.ToString();
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnEditBM_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index]["MaBM"] = txbMaBM.Text;
            table.Rows[index]["TenBM"] = txbTenBM.Text;
            table.Rows[index]["MaKhoa"] = cbxKhoa.SelectedValue.ToString();
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvBM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql);
            if (index >= 0)
            {
                txbMaBM.Text = table.Rows[index]["MaBM"].ToString();
                txbTenBM.Text = table.Rows[index]["TenBM"].ToString();
                cbxKhoa.SelectedValue = table.Rows[index]["MaKhoa"].ToString();
            }
        }

        private void btnDelBM_Click(object sender, EventArgs e)
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
