namespace QuanLiDaoTao
{
    partial class BacDaoTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacDaoTao));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBDT = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditBDT = new System.Windows.Forms.Button();
            this.btnDelBDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTenBDT = new System.Windows.Forms.TextBox();
            this.txbMaBDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoadBDT = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadBDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBDT);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnEditBDT);
            this.groupBox2.Controls.Add(this.btnDelBDT);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnAddBDT
            // 
            this.btnAddBDT.Location = new System.Drawing.Point(6, 27);
            this.btnAddBDT.Name = "btnAddBDT";
            this.btnAddBDT.Size = new System.Drawing.Size(75, 56);
            this.btnAddBDT.TabIndex = 2;
            this.btnAddBDT.Text = "Thêm";
            this.btnAddBDT.UseVisualStyleBackColor = true;
            this.btnAddBDT.Click += new System.EventHandler(this.btnAddBDT_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(188, 24);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEditBDT
            // 
            this.btnEditBDT.Location = new System.Drawing.Point(119, 27);
            this.btnEditBDT.Name = "btnEditBDT";
            this.btnEditBDT.Size = new System.Drawing.Size(75, 23);
            this.btnEditBDT.TabIndex = 3;
            this.btnEditBDT.Text = "Sửa";
            this.btnEditBDT.UseVisualStyleBackColor = true;
            this.btnEditBDT.Click += new System.EventHandler(this.btnEditBDT_Click);
            // 
            // btnDelBDT
            // 
            this.btnDelBDT.Location = new System.Drawing.Point(119, 60);
            this.btnDelBDT.Name = "btnDelBDT";
            this.btnDelBDT.Size = new System.Drawing.Size(75, 23);
            this.btnDelBDT.TabIndex = 4;
            this.btnDelBDT.Text = "Xóa";
            this.btnDelBDT.UseVisualStyleBackColor = true;
            this.btnDelBDT.Click += new System.EventHandler(this.btnDelBDT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTenBDT);
            this.groupBox1.Controls.Add(this.txbMaBDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bậc đào tạo";
            // 
            // txbTenBDT
            // 
            this.txbTenBDT.Location = new System.Drawing.Point(105, 67);
            this.txbTenBDT.Name = "txbTenBDT";
            this.txbTenBDT.Size = new System.Drawing.Size(214, 20);
            this.txbTenBDT.TabIndex = 3;
            // 
            // txbMaBDT
            // 
            this.txbMaBDT.Location = new System.Drawing.Point(105, 32);
            this.txbMaBDT.Name = "txbMaBDT";
            this.txbMaBDT.Size = new System.Drawing.Size(214, 20);
            this.txbMaBDT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bậc đào tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bậc đào tạo";
            // 
            // dgvLoadBDT
            // 
            this.dgvLoadBDT.AllowUserToAddRows = false;
            this.dgvLoadBDT.AllowUserToDeleteRows = false;
            this.dgvLoadBDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoadBDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadBDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoadBDT.Location = new System.Drawing.Point(0, 148);
            this.dgvLoadBDT.Name = "dgvLoadBDT";
            this.dgvLoadBDT.ReadOnly = true;
            this.dgvLoadBDT.Size = new System.Drawing.Size(593, 161);
            this.dgvLoadBDT.TabIndex = 7;
            this.dgvLoadBDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadBDT_CellClick);
            // 
            // BacDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadBDT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BacDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bậc đào tạo";
            this.Load += new System.EventHandler(this.BacDaoTao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadBDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditBDT;
        private System.Windows.Forms.Button btnDelBDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenBDT;
        private System.Windows.Forms.TextBox txbMaBDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadBDT;
        private System.Windows.Forms.Button btnAddBDT;
    }
}