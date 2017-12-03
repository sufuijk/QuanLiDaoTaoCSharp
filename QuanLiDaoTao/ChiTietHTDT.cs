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
    public partial class ChiTietHTDT : Form
    {
        public ChiTietHTDT()
        {
            InitializeComponent();
        }

        string sql = "SELECT * FROM HINHTHUC_DAOTAO";

        private void LoadData()
        {
            dgvHTDT.DataSource = Database.Instance.LoadData(sql);
        }
        private void ChiTietHTDT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
