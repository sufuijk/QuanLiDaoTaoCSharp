using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using AppExcel = Microsoft.Office.Interop.Excel.Application;

using DataTable = System.Data.DataTable;
namespace QuanLiDaoTao
{
    public partial class QuanLiDaoTao : Form
    {
        public QuanLiDaoTao()
        {
            InitializeComponent();
        }
        
        public int GrantUser;
        int index; // index for Giangvien
        int index2; // index for HTDT

        private string sql = "SELECT * FROM GiangVien";
        private string sql1 = "SELECT * FROM Dantoc";
        private string sql2 = "SELECT * FROM Bomon";
        private string sql3 = "SELECT * FROM Nganh_Daotao";
        private string sql4 = "SELECT * FROM Bacdaotao";
        private string sql5 = "SELECT * FROM Noidaotao";
        private string sql6 = "SELECT * FROM Hinhthuc_daotao";
        private string sql7 = "SELECT * FROM CHITIET_HTDT";
        public void setCombobox()
        {
            cbxDantoc.DataSource = Database.Instance.LoadData(sql1);
            cbxDantoc.ValueMember = "MaDanToc";
            cbxDantoc.DisplayMember = "TenDanToc";

            cbxBM.DataSource = Database.Instance.LoadData(sql2);
            cbxBM.ValueMember = "MaBM";
            cbxBM.DisplayMember = "TenBM";

            cbxCTHTDT.DataSource = Database.Instance.LoadData(sql7);
            cbxCTHTDT.ValueMember = "STTHTDT";
            cbxCTHTDT.DisplayMember = "Chitiet";

            cbxMaNganhDT.DataSource = Database.Instance.LoadData(sql3);
            cbxMaNganhDT.ValueMember = "MaNganhDT";
            cbxMaNganhDT.DisplayMember = "TenNganhDT";

            cbxBDT.DataSource = Database.Instance.LoadData(sql4);
            cbxBDT.ValueMember = "MaBacDT";
            cbxBDT.DisplayMember = "TenBacDT";

            cbxNoiDT.DataSource = Database.Instance.LoadData(sql5);
            cbxNoiDT.ValueMember = "MaNoiDT";
            cbxNoiDT.DisplayMember = "TenNoiDT";

            cbxMaHTDT.DataSource = Database.Instance.LoadData(sql6);
            cbxMaHTDT.ValueMember = "MaHTDT";
            cbxMaHTDT.DisplayMember = "TenHTDT";

            //Set default index for combobox Gioitinh
            cbxGioiTinh.SelectedIndex = 0;
        }

        private void LoadData()
        {
           
            dgvLoadGiangvien.DataSource = Database.Instance.LoadData(this.sql);
            DataTable table = new DataTable();
            table = Database.Instance.LoadData(this.sql);
            AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();
            for (int i = 0; i < dgvLoadGiangvien.Rows.Count; i++)
            {
                autocomplete.Add(table.Rows[i]["Ten"].ToString());
                autocomplete.Add(table.Rows[i]["MaGV"].ToString());
            }
            txbSearch.AutoCompleteCustomSource = autocomplete;

        }
        private void LoadUser()
        {
            txbDetailUsername.Text = Account.User.getUsername();
            txbDetailGrantUser.Text = Account.User.getGrant();
            txbDetailNoteUser.Text = Account.User.getDetail();
        }
        private void LoadData2()
        {
            dgvLoadHTDT.DataSource = Database.Instance.LoadData(this.sql7);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //Phân quyền ở đây 
            //1 là administrator
            //khác là user 
            LoadUser();
            if (int.Parse(Account.User.getGrant()) != 1)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage7);
            }else
            {
                LoadData();
                LoadData2();
                LoadStatictis();
            }

            setCombobox();
        }

       

        private void btnDetailBM_Click(object sender, EventArgs e)
        {
            BoMon bomon = new BoMon();
            bomon.ShowDialog();
            setCombobox();
        }

        

        private void QuanLiDaoTao_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            if (txbMaGV.Text == null || txbMaGV.Text == "" || txbHoGV.Text == null ||
                txbHoGV.Text == "" || txbTenGV.Text == null || txbTenGV.Text == "" ||
                txbHuongbotri.Text == null || txbHuongbotri.Text == "" || txbKinhphi.Text == null ||
                txbKinhphi.Text == "")
            {
                MessageBox.Show("Chỉ được để trống tên lót!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(dtpThoigianBD.Value >= dtpThoigianKT.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (dtpNgaySinhGV.Value > DateTime.Parse("1-1-1993"))
            {
                MessageBox.Show("Tuổi phải lớn hơn 24", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable table = Database.Instance.LoadData(sql);

                DataRow newRow = table.NewRow();
                newRow["MaGV"] = txbMaGV.Text;
                newRow["Ho"] = txbHoGV.Text;
                newRow["TenLot"] = txbTenLotGV.Text;
                newRow["Ten"] = txbTenGV.Text;
                newRow["GioiTinh"] = cbxGioiTinh.SelectedItem;
                newRow["NgaySinh"] = dtpNgaySinhGV.Value;
                newRow["KinhPhi"] = txbKinhphi.Text;
                newRow["TG_BatDau"] = dtpThoigianBD.Value;
                newRow["TG_KetThuc"] = dtpThoigianKT.Value;
                newRow["HuongBoTri"] = txbHuongbotri.Text;
                newRow["MaDanToc"] = cbxDantoc.SelectedValue;
                newRow["MaBM"] = cbxBM.SelectedValue;
                newRow["STTHTDT"] = cbxCTHTDT.SelectedValue;
                newRow["MaNoiDT"] = cbxNoiDT.SelectedValue;
                newRow["MaBacDT"] = cbxBDT.SelectedValue;
                table.Rows.Add(newRow);
                Database.Instance.Update(table);
                LoadData();
                MessageBox.Show("Nhập giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLoadGiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql);
            index = e.RowIndex;
            if (index >= 0)
            {
                
                txbHoGV.Text = table.Rows[index]["Ho"].ToString();
                txbTenLotGV.Text = table.Rows[index]["TenLot"].ToString();
                txbTenGV.Text = table.Rows[index]["Ten"].ToString();
                cbxGioiTinh.SelectedItem = table.Rows[index]["GioiTinh"].ToString();
                dtpNgaySinhGV.Value = DateTime.Parse(table.Rows[index]["NgaySinh"].ToString());
                dtpThoigianBD.Value = DateTime.Parse(table.Rows[index]["TG_BatDau"].ToString());
                dtpThoigianKT.Value = DateTime.Parse(table.Rows[index]["TG_KetThuc"].ToString());
                txbHuongbotri.Text = table.Rows[index]["HuongBoTri"].ToString();
                txbKinhphi.Text = table.Rows[index]["KinhPhi"].ToString();
                cbxDantoc.SelectedValue = table.Rows[index]["MaDanToc"].ToString();
                cbxBM.SelectedValue = table.Rows[index]["MaBM"].ToString();
                cbxCTHTDT.SelectedValue = table.Rows[index]["STTHTDT"].ToString();
                cbxNoiDT.SelectedValue = table.Rows[index]["MaNoiDT"].ToString();
                cbxBDT.SelectedValue = table.Rows[index]["MaBacDT"].ToString();
            }

        }

        private void btnEditGV_Click(object sender, EventArgs e)
        {
            
            DataTable table = Database.Instance.LoadData(this.sql);
            table.Rows[index]["MaGV"] = (txbMaGV.Text == null || txbMaGV.Text == "") ? table.Rows[index]["MaGV"].ToString() : txbMaGV.Text;
            table.Rows[index]["Ho"] = txbHoGV.Text;
            table.Rows[index]["TenLot"] = txbTenLotGV.Text;
            table.Rows[index]["Ten"] = txbTenGV.Text;
            table.Rows[index]["GioiTinh"] = cbxGioiTinh.SelectedItem;
            table.Rows[index]["NgaySinh"] = dtpNgaySinhGV.Value;
            table.Rows[index]["TG_BatDau"] = dtpThoigianBD.Value;
            table.Rows[index]["TG_KetThuc"] = dtpThoigianKT.Value;
            table.Rows[index]["HuongBoTri"] = txbHuongbotri.Text;
            table.Rows[index]["KinhPhi"] = txbKinhphi.Text;
            table.Rows[index]["MaDanToc"] = cbxDantoc.SelectedValue;
            table.Rows[index]["MaBM"] = cbxBM.SelectedValue;
            table.Rows[index]["STTHTDT"] = cbxCTHTDT.SelectedValue;
            table.Rows[index]["MaNoiDT"] = cbxNoiDT.SelectedValue;
            table.Rows[index]["MaBacDT"] = cbxBDT.SelectedValue;
            Database.Instance.Update(table);
            LoadData();
            MessageBox.Show("Chỉnh sửa giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       

        private void txbMaGV_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM GIANGVIEN WHERE MaGV='"+txbMaGV.Text+"'";
            int result = Database.Instance.CheckUser(query);
            if (result > 0)
            {
                MessageBox.Show("Trùng mã","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            AppExcel obj = new AppExcel();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            saveFileDialog1.DefaultExt = "xlsm";
            saveFileDialog1.Filter = "XLS file (*.xls)|*.xls|XLSM file (*.xlsm)|*.xml|XLSX file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Where do you want to save the file?";

            saveFileDialog1.InitialDirectory = @"C:\";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < dgvLoadGiangvien.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = dgvLoadGiangvien.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvLoadGiangvien.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvLoadGiangvien.Columns.Count; j++)
                    {
                        if (dgvLoadGiangvien.Rows[i].Cells[j] != null)
                        {
                            obj.Cells[i + 2, j + 1] = dgvLoadGiangvien.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                // Tinh sum 
                string sql = "SELECT SUM(KINHPHI) AS TONG FROM GIANGVIEN";
                int sum = Database.Instance.SumAttribute(sql);
                
                obj.Cells[dgvLoadGiangvien.Columns.Count + 1, 1] = "Tổng kinh phí";
                obj.Cells[dgvLoadGiangvien.Columns.Count + 1, 2] = sum;

                obj.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName);
                obj.ActiveWorkbook.Saved = true;

                

                MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nơi lưu file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

            

        }


        private void btnRefreshDetailHTDT_Click(object sender, EventArgs e)
        {
            LoadData2();
        }

        private void dgvLoadHTDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
            DataTable table = Database.Instance.LoadData(sql7);
            if (index2 >= 0)
            {
                cbxMaHTDT.SelectedValue = table.Rows[index2]["MaHTDT"].ToString();
                cbxMaNganhDT.SelectedValue = table.Rows[index2]["MaNganhDT"].ToString();
                txbSttDetailHTDT.Text = table.Rows[index2]["SttHTDT"].ToString();
            }
        }

        private void btnAddDetailHTDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql7);
            DataRow newRow = table.NewRow();
            newRow["MaHTDT"] = cbxMaHTDT.SelectedValue;
            newRow["MaNganhDT"] = cbxMaNganhDT.SelectedValue;
            newRow["Chitiet"] = cbxMaNganhDT.GetItemText(cbxMaNganhDT.SelectedItem) + " - " + cbxMaHTDT.GetItemText(cbxMaHTDT.SelectedItem);
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData2();
        }

        private void btnDelDetailHTDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql7);
            if (index2 >= 0)
            {
                table.Rows[index2].Delete();
                Database.Instance.Update(table);
                LoadData2();
            }
        }

        private void btnEditDetailHTDT_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(sql7);
            if (index2 >= 0)
            {
                string temp = (cbxMaNganhDT.GetItemText(cbxMaNganhDT.SelectedItem) + " - " + cbxMaHTDT.GetItemText(cbxMaHTDT.SelectedItem));
                table.Rows[index2]["MaHTDT"] = cbxMaHTDT.SelectedValue;
                table.Rows[index2]["MaNganhDT"] = cbxMaNganhDT.SelectedValue;
                table.Rows[index2]["Chitiet"] =temp;
                Database.Instance.Update(table);
                LoadData2();
            }
        }

        private void btnDetailNganhDT_Click(object sender, EventArgs e)
        {
            NganhDaoTao nghanhdaotao = new NganhDaoTao();
            nghanhdaotao.ShowDialog();
            setCombobox();
        }

        private void btnDetailHTDT_Click(object sender, EventArgs e)
        {
            HinhThucDaoTao htdt = new HinhThucDaoTao();
            htdt.ShowDialog();
            setCombobox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ACCOUNT WHERE USERNAME ='"+Account.User.getUsername()+"'";
            DataTable table = Database.Instance.LoadData(query);
            if(txbOldPasswd.Text == Account.User.getPassword() && txbNewPasswd.Text != "")
            {
                table.Rows[0]["PASSWD"] = txbNewPasswd.Text;
                Database.Instance.Update(table);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Account.User.setPasswd(txbNewPasswd.Text);
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại! Sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void LoadStatictis()
        {
            chartStatistic.Series["Số lượng"].Points.Clear();

            string query = "SELECT COUNT(*) AS NUMBER FROM BOMON";
            string query1 = "SELECT COUNT(*) AS NUMBER FROM KHOA";
            string query2 = "SELECT COUNT(*) AS NUMBER FROM NOIDAOTAO";
            string query3 = "SELECT COUNT(*) AS NUMBER FROM GIANGVIEN";

            int soLuongBoMon = Database.Instance.CountAttribute(query);
            int soLuongKhoa = Database.Instance.CountAttribute(query1);
            int soLuongNDT = Database.Instance.CountAttribute(query2);
            int soLuongGV = Database.Instance.CountAttribute(query3);

            chartStatistic.Series["Số lượng"].Points.AddXY("Bộ môn", soLuongBoMon);
            chartStatistic.Series["Số lượng"].Points.AddXY("Khoa", soLuongKhoa);
            chartStatistic.Series["Số lượng"].Points.AddXY("Nơi đào tạo", soLuongNDT);
            chartStatistic.Series["Số lượng"].Points.AddXY("Giảng viên", soLuongGV);

        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            LoadStatictis();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radioName.Checked == true)
            {
                sql = "SELECT * FROM GIANGVIEN WHERE Ten LIKE N'%" + txbSearch.Text + "%'";
                dgvTimKiem.DataSource = Database.Instance.LoadData(sql);
            }
            else
            {
                sql = "SELECT * FROM GIANGVIEN WHERE MaGV LIKE N'%" + txbSearch.Text + "%'";
                dgvTimKiem.DataSource = Database.Instance.LoadData(sql);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;
        }

        private void dgvLoadGiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartStatistic_Click(object sender, EventArgs e)
        {

        }

        private void txbKinhphi_TextChanged(object sender, EventArgs e)
        {
            string tString = txbKinhphi.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Không được nhập chữ");
                    txbKinhphi.Text = "";
                    return;
                }

            }
            //If it get's here it's a valid number
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioID_CheckedChanged(object sender,EventArgs e)
        {
           
        }

    }
}
