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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBDT = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditBDT = new System.Windows.Forms.Button();
            this.btnDelBDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
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
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(188, 24);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEditBDT
            // 
            this.btnEditBDT.Location = new System.Drawing.Point(119, 27);
            this.btnEditBDT.Name = "btnEditBDT";
            this.btnEditBDT.Size = new System.Drawing.Size(75, 23);
            this.btnEditBDT.TabIndex = 3;
            this.btnEditBDT.Text = "Sửa";
            this.btnEditBDT.UseVisualStyleBackColor = true;
            // 
            // btnDelBDT
            // 
            this.btnDelBDT.Location = new System.Drawing.Point(119, 60);
            this.btnDelBDT.Name = "btnDelBDT";
            this.btnDelBDT.Size = new System.Drawing.Size(75, 23);
            this.btnDelBDT.TabIndex = 4;
            this.btnDelBDT.Text = "Xóa";
            this.btnDelBDT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTenKhoa);
            this.groupBox1.Controls.Add(this.txbMaKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bậc đào tạo";
            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Location = new System.Drawing.Point(105, 67);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(214, 20);
            this.txbTenKhoa.TabIndex = 3;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(105, 32);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(214, 20);
            this.txbMaKhoa.TabIndex = 2;
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
            this.dgvLoadBDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadBDT.Location = new System.Drawing.Point(12, 140);
            this.dgvLoadBDT.Name = "dgvLoadBDT";
            this.dgvLoadBDT.ReadOnly = true;
            this.dgvLoadBDT.Size = new System.Drawing.Size(569, 161);
            this.dgvLoadBDT.TabIndex = 7;
            // 
            // BacDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadBDT);
            this.Name = "BacDaoTao";
            this.Text = "BacDaoTao";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadBDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBDT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditBDT;
        private System.Windows.Forms.Button btnDelBDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenKhoa;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadBDT;
    }
}