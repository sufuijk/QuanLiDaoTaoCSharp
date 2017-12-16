namespace QuanLiDaoTao
{
    partial class BoMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoMon));
            this.dgvBM = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenBM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaBM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddBM = new System.Windows.Forms.Button();
            this.btnEditBM = new System.Windows.Forms.Button();
            this.btnDelBM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBM
            // 
            this.dgvBM.AllowUserToAddRows = false;
            this.dgvBM.AllowUserToDeleteRows = false;
            this.dgvBM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBM.Location = new System.Drawing.Point(12, 208);
            this.dgvBM.Name = "dgvBM";
            this.dgvBM.ReadOnly = true;
            this.dgvBM.Size = new System.Drawing.Size(554, 135);
            this.dgvBM.TabIndex = 0;
            this.dgvBM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBM_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxKhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbTenBM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMaBM);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bộ môn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(103, 101);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbxKhoa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bộ môn";
            // 
            // txbTenBM
            // 
            this.txbTenBM.Location = new System.Drawing.Point(103, 66);
            this.txbTenBM.Name = "txbTenBM";
            this.txbTenBM.Size = new System.Drawing.Size(202, 20);
            this.txbTenBM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bộ môn";
            // 
            // txbMaBM
            // 
            this.txbMaBM.Location = new System.Drawing.Point(103, 33);
            this.txbMaBM.Name = "txbMaBM";
            this.txbMaBM.Size = new System.Drawing.Size(202, 20);
            this.txbMaBM.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnAddBM);
            this.groupBox2.Controls.Add(this.btnEditBM);
            this.groupBox2.Controls.Add(this.btnDelBM);
            this.groupBox2.Location = new System.Drawing.Point(356, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 104);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(188, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddBM
            // 
            this.btnAddBM.Location = new System.Drawing.Point(6, 36);
            this.btnAddBM.Name = "btnAddBM";
            this.btnAddBM.Size = new System.Drawing.Size(98, 52);
            this.btnAddBM.TabIndex = 7;
            this.btnAddBM.Text = "Thêm";
            this.btnAddBM.UseVisualStyleBackColor = true;
            this.btnAddBM.Click += new System.EventHandler(this.btnAddBM_Click);
            // 
            // btnEditBM
            // 
            this.btnEditBM.Location = new System.Drawing.Point(110, 36);
            this.btnEditBM.Name = "btnEditBM";
            this.btnEditBM.Size = new System.Drawing.Size(75, 23);
            this.btnEditBM.TabIndex = 8;
            this.btnEditBM.Text = "Sửa";
            this.btnEditBM.UseVisualStyleBackColor = true;
            this.btnEditBM.Click += new System.EventHandler(this.btnEditBM_Click);
            // 
            // btnDelBM
            // 
            this.btnDelBM.Location = new System.Drawing.Point(110, 65);
            this.btnDelBM.Name = "btnDelBM";
            this.btnDelBM.Size = new System.Drawing.Size(75, 23);
            this.btnDelBM.TabIndex = 9;
            this.btnDelBM.Text = "Xóa";
            this.btnDelBM.UseVisualStyleBackColor = true;
            this.btnDelBM.Click += new System.EventHandler(this.btnDelBM_Click);
            // 
            // BoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bộ môn";
            this.Load += new System.EventHandler(this.BoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenBM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaBM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBM;
        private System.Windows.Forms.Button btnEditBM;
        private System.Windows.Forms.Button btnDelBM;
        private System.Windows.Forms.Button btnRefresh;
    }
}