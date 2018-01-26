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
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(552, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngành đào tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ngành đào tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã ngành";
            // 
            // txbTenNDT
            // 
            this.txbTenNDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNDT.Location = new System.Drawing.Point(238, 105);
            this.txbTenNDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenNDT.Name = "txbTenNDT";
            this.txbTenNDT.Size = new System.Drawing.Size(264, 26);
            this.txbTenNDT.TabIndex = 1;
            // 
            // txbMaNDT
            // 
            this.txbMaNDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNDT.Location = new System.Drawing.Point(238, 60);
            this.txbMaNDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMaNDT.Name = "txbMaNDT";
            this.txbMaNDT.Size = new System.Drawing.Size(264, 26);
            this.txbMaNDT.TabIndex = 0;
            // 
            // dgvNDT
            // 
            this.dgvNDT.AllowUserToAddRows = false;
            this.dgvNDT.AllowUserToDeleteRows = false;
            this.dgvNDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNDT.Location = new System.Drawing.Point(0, 235);
            this.dgvNDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNDT.Name = "dgvNDT";
            this.dgvNDT.ReadOnly = true;
            this.dgvNDT.Size = new System.Drawing.Size(868, 184);
            this.dgvNDT.TabIndex = 1;
            this.dgvNDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNDT_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDelNDT);
            this.groupBox2.Controls.Add(this.btnEditNDT);
            this.groupBox2.Controls.Add(this.btnAddNDT);
            this.groupBox2.Location = new System.Drawing.Point(579, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(274, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 133);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(249, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelNDT
            // 
            this.btnDelNDT.Location = new System.Drawing.Point(146, 83);
            this.btnDelNDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelNDT.Name = "btnDelNDT";
            this.btnDelNDT.Size = new System.Drawing.Size(112, 41);
            this.btnDelNDT.TabIndex = 2;
            this.btnDelNDT.Text = "Xóa";
            this.btnDelNDT.UseVisualStyleBackColor = true;
            this.btnDelNDT.Click += new System.EventHandler(this.btnDelNDT_Click);
            // 
            // btnEditNDT
            // 
            this.btnEditNDT.Location = new System.Drawing.Point(146, 28);
            this.btnEditNDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditNDT.Name = "btnEditNDT";
            this.btnEditNDT.Size = new System.Drawing.Size(112, 47);
            this.btnEditNDT.TabIndex = 1;
            this.btnEditNDT.Text = "Sửa";
            this.btnEditNDT.UseVisualStyleBackColor = true;
            this.btnEditNDT.Click += new System.EventHandler(this.btnEditNDT_Click);
            // 
            // btnAddNDT
            // 
            this.btnAddNDT.Location = new System.Drawing.Point(9, 28);
            this.btnAddNDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNDT.Name = "btnAddNDT";
            this.btnAddNDT.Size = new System.Drawing.Size(112, 96);
            this.btnAddNDT.TabIndex = 0;
            this.btnAddNDT.Text = "Thêm";
            this.btnAddNDT.UseVisualStyleBackColor = true;
            this.btnAddNDT.Click += new System.EventHandler(this.btnAddNDT_Click);
            // 
            // NganhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNDT);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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