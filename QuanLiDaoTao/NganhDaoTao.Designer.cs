namespace QuanLiDaoTao
{
    partial class NganhDaoTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NganhDaoTao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenNDT = new System.Windows.Forms.TextBox();
            this.txbMaNDT = new System.Windows.Forms.TextBox();
            this.dgvNDT = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelNDT = new System.Windows.Forms.Button();
            this.btnEditNDT = new System.Windows.Forms.Button();
            this.btnAddNDT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTenNDT);
            this.groupBox1.Controls.Add(this.txbMaNDT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngành đào tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ngành đào tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã ngành";
            // 
            // txbTenNDT
            // 
            this.txbTenNDT.Location = new System.Drawing.Point(159, 72);
            this.txbTenNDT.Name = "txbTenNDT";
            this.txbTenNDT.Size = new System.Drawing.Size(177, 20);
            this.txbTenNDT.TabIndex = 1;
            // 
            // txbMaNDT
            // 
            this.txbMaNDT.Location = new System.Drawing.Point(159, 41);
            this.txbMaNDT.Name = "txbMaNDT";
            this.txbMaNDT.Size = new System.Drawing.Size(177, 20);
            this.txbMaNDT.TabIndex = 0;
            // 
            // dgvNDT
            // 
            this.dgvNDT.AllowUserToAddRows = false;
            this.dgvNDT.AllowUserToDeleteRows = false;
            this.dgvNDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNDT.Location = new System.Drawing.Point(0, 161);
            this.dgvNDT.Name = "dgvNDT";
            this.dgvNDT.ReadOnly = true;
            this.dgvNDT.Size = new System.Drawing.Size(579, 126);
            this.dgvNDT.TabIndex = 1;
            this.dgvNDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNDT_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDelNDT);
            this.groupBox2.Controls.Add(this.btnEditNDT);
            this.groupBox2.Controls.Add(this.btnAddNDT);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 91);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(166, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelNDT
            // 
            this.btnDelNDT.Location = new System.Drawing.Point(97, 57);
            this.btnDelNDT.Name = "btnDelNDT";
            this.btnDelNDT.Size = new System.Drawing.Size(75, 28);
            this.btnDelNDT.TabIndex = 2;
            this.btnDelNDT.Text = "Xóa";
            this.btnDelNDT.UseVisualStyleBackColor = true;
            this.btnDelNDT.Click += new System.EventHandler(this.btnDelNDT_Click);
            // 
            // btnEditNDT
            // 
            this.btnEditNDT.Location = new System.Drawing.Point(97, 19);
            this.btnEditNDT.Name = "btnEditNDT";
            this.btnEditNDT.Size = new System.Drawing.Size(75, 32);
            this.btnEditNDT.TabIndex = 1;
            this.btnEditNDT.Text = "Sửa";
            this.btnEditNDT.UseVisualStyleBackColor = true;
            this.btnEditNDT.Click += new System.EventHandler(this.btnEditNDT_Click);
            // 
            // btnAddNDT
            // 
            this.btnAddNDT.Location = new System.Drawing.Point(6, 19);
            this.btnAddNDT.Name = "btnAddNDT";
            this.btnAddNDT.Size = new System.Drawing.Size(75, 66);
            this.btnAddNDT.TabIndex = 0;
            this.btnAddNDT.Text = "Thêm";
            this.btnAddNDT.UseVisualStyleBackColor = true;
            this.btnAddNDT.Click += new System.EventHandler(this.btnAddNDT_Click);
            // 
            // NganhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNDT);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NganhDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí ngành đào tạo";
            this.Load += new System.EventHandler(this.NganhDaoTao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenNDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelNDT;
        private System.Windows.Forms.Button btnEditNDT;
        private System.Windows.Forms.Button btnAddNDT;
        private System.Windows.Forms.TextBox txbMaNDT;
    }
}