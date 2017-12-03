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
        int index;

        private string sql1 = "SELECT * FROM Dantoc";
        private string sql2 = "SELECT * FROM Bomon";
        private string sql3 = "SELECT * FROM Nganh_Daotao";
        private string sql4 = "SELECT * FROM Bacdaotao";
        private string sql5 = "SELECT * FROM Noidaotao";

        public void setCombobox()
        {
            cbxDantoc.DataSource = Database.Instance.LoadData(sql1);
            cbxDantoc.ValueMember = "MaDanToc";
            cbxDantoc.DisplayMember = "TenDanToc";

            cbxBM.DataSource = Database.Instance.LoadData(sql2);
            cbxBM.ValueMember = "MaBM";
            cbxBM.DisplayMember = "TenBM";

            cbxNganhDT.DataSource = Database.Instance.LoadData(sql3);
            cbxNganhDT.ValueMember = "MaNganhDT";
            cbxNganhDT.DisplayMember = "TenNganhDT";

            cbxBDT.DataSource = Database.Instance.LoadData(sql4);
            cbxBDT.ValueMember = "MaBacDT";
            cbxBDT.DisplayMember = "TenBacDT";

            cbxNoiDT.DataSource = Database.Instance.LoadData(sql5);
            cbxNoiDT.ValueMember = "MaNoiDT";
            cbxNoiDT.DisplayMember = "TenNoiDT";
        }
        private void LoadData()
        {
            dgvLoadGiangvien.DataSource = Database.Instance.LoadData(sql);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            //Phân quyền ở đây 
            //1 là administrator
            //khác là user 
            if (GaintUser != 1)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage5);
            }

            setCombobox();
        }

       

        private void btnDetailBM_Click(object sender, EventArgs e)
        {
            BoMon bomon = new BoMon();
            bomon.ShowDialog();
            setCombobox();
        }

        private void btnDetailNDT_Click(object sender, EventArgs e)
        {
            NganhDaoTao nghanhdaotao = new NganhDaoTao();
            nghanhdaotao.ShowDialog();
            setCombobox();
        }

        private void QuanLiDaoTao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDetailDT_Click(object sender, EventArgs e)
        {
            DanToc dantoc = new DanToc();
            dantoc.ShowDialog();
            setCombobox();
        }

        private void btnDetailBDT_Click(object sender, EventArgs e)
        {
            BacDaoTao bacdaotao = new BacDaoTao();
            bacdaotao.ShowDialog();
            setCombobox();
        }

        private void btnDetailNoiDT_Click(object sender, EventArgs e)
        {
            NoiDaoTao noidaotao = new NoiDaoTao();
            noidaotao.ShowDialog();
            setCombobox();
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
            MessageBox.Show("Thêm tài khoản thành công", "Thông báo");
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            DataRow newRow = table.NewRow();
            newRow["MaGV"] = txbMaGV.Text;
            newRow["Ho"] = txbHoGV.Text;
            newRow["TenLot"] = txbTenLotGV.Text;
            newRow["Ten"] = txbTenGV.Text;
            newRow["NgaySinh"] = dtpNgaySinhGV.Value;
            newRow["KinhPhi"] = txbKinhphi.Text;
            newRow["TG_DuKien"] = dtpThoigiandukien.Value;
            newRow["HuongBoTri"] = txbHuongbotri.Text;
            newRow["MaDanToc"] = cbxDantoc.SelectedValue;
            newRow["MaBM"] = cbxBM.SelectedValue;
            newRow["MaNganhDT"] = cbxNganhDT.SelectedValue;
            newRow["MaNoiDT"] = cbxNoiDT.SelectedValue;
            newRow["MaBacDT"] = cbxBDT.SelectedValue;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvLoadGiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            index = e.RowIndex;
            if (index >= 0)
            {
                txbMaGV.Text = table.Rows[index]["MaGV"].ToString();
                txbHoGV.Text = table.Rows[index]["Ho"].ToString();
                txbTenLotGV.Text = table.Rows[index]["TenLot"].ToString();
                txbTenGV.Text = table.Rows[index]["Ten"].ToString();
                dtpNgaySinhGV.Value = DateTime.Parse(table.Rows[index]["NgaySinh"].ToString());
                dtpThoigiandukien.Value = DateTime.Parse(table.Rows[index]["TG_DuKien"].ToString());
                txbHuongbotri.Text = table.Rows[index]["HuongBoTri"].ToString();
                txbKinhphi.Text = table.Rows[index]["KinhPhi"].ToString();
                cbxDantoc.SelectedValue = table.Rows[index]["MaDanToc"].ToString();
                cbxBM.SelectedValue = table.Rows[index]["MaBM"].ToString();
                cbxNganhDT.SelectedValue = table.Rows[index]["MaNganhDT"].ToString();
                cbxNoiDT.SelectedValue = table.Rows[index]["MaNoiDT"].ToString();
                cbxBDT.SelectedValue = table.Rows[index]["MaBacDT"].ToString();
            }

        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            table.Rows[index]["MaGV"] = txbMaGV.Text;
            table.Rows[index]["Ho"] = txbHoGV.Text;
            table.Rows[index]["TenLot"] = txbTenLotGV.Text;
            table.Rows[index]["Ten"] = txbTenGV.Text;
            table.Rows[index]["NgaySinh"] = dtpNgaySinhGV.Value;
            table.Rows[index]["TG_DuKien"] = dtpThoigiandukien.Value;
            table.Rows[index]["HuongBoTri"] = txbHuongbotri.Text;
            table.Rows[index]["KinhPhi"] = txbKinhphi.Text;
            table.Rows[index]["MaDanToc"] = cbxDantoc.SelectedValue;
            table.Rows[index]["MaBM"] = cbxBM.SelectedValue;
            table.Rows[index]["MaNganhDT"] = cbxNganhDT.SelectedValue;
            table.Rows[index]["MaNoiDT"] = cbxNoiDT.SelectedValue;
            table.Rows[index]["MaBacDT"] = cbxBDT.SelectedValue;
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnDelGV_Click(object sender, EventArgs e)
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

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GIANGVIEN WHERE MaGV='" + txbSearchID.Text + "'";
            dgvTimKiem.DataSource = Database.Instance.LoadData(sql);

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM GIANGVIEN WHERE Ten=N'" + txbSearchName.Text + "'";
            dgvTimKiem.DataSource = Database.Instance.LoadData(sql);
        }
    }
}
