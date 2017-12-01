namespace QuanLiDaoTao
{
    partial class NoiDaoTao
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
            this.btnAddNoiDT = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditNoiDT = new System.Windows.Forms.Button();
            this.btnDelNoiDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoadNoiDT = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadNoiDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddNoiDT);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnEditNoiDT);
            this.groupBox2.Controls.Add(this.btnDelNoiDT);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnAddNoiDT
            // 
            this.btnAddNoiDT.Location = new System.Drawing.Point(6, 27);
            this.btnAddNoiDT.Name = "btnAddNoiDT";
            this.btnAddNoiDT.Size = new System.Drawing.Size(75, 56);
            this.btnAddNoiDT.TabIndex = 2;
            this.btnAddNoiDT.Text = "Thêm";
            this.btnAddNoiDT.UseVisualStyleBackColor = true;
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
            // btnEditNoiDT
            // 
            this.btnEditNoiDT.Location = new System.Drawing.Point(119, 27);
            this.btnEditNoiDT.Name = "btnEditNoiDT";
            this.btnEditNoiDT.Size = new System.Drawing.Size(75, 23);
            this.btnEditNoiDT.TabIndex = 3;
            this.btnEditNoiDT.Text = "Sửa";
            this.btnEditNoiDT.UseVisualStyleBackColor = true;
            // 
            // btnDelNoiDT
            // 
            this.btnDelNoiDT.Location = new System.Drawing.Point(119, 60);
            this.btnDelNoiDT.Name = "btnDelNoiDT";
            this.btnDelNoiDT.Size = new System.Drawing.Size(75, 23);
            this.btnDelNoiDT.TabIndex = 4;
            this.btnDelNoiDT.Text = "Xóa";
            this.btnDelNoiDT.UseVisualStyleBackColor = true;
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
            this.groupBox1.Text = "Thông tin nơi đào tạo";
            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Location = new System.Drawing.Point(108, 67);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(211, 20);
            this.txbTenKhoa.TabIndex = 3;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(108, 32);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(211, 20);
            this.txbMaKhoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nơi đào tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nơi đào tạo";
            // 
            // dgvLoadNoiDT
            // 
            this.dgvLoadNoiDT.AllowUserToAddRows = false;
            this.dgvLoadNoiDT.AllowUserToDeleteRows = false;
            this.dgvLoadNoiDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadNoiDT.Location = new System.Drawing.Point(12, 140);
            this.dgvLoadNoiDT.Name = "dgvLoadNoiDT";
            this.dgvLoadNoiDT.ReadOnly = true;
            this.dgvLoadNoiDT.Size = new System.Drawing.Size(569, 161);
            this.dgvLoadNoiDT.TabIndex = 7;
            // 
            // NoiDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadNoiDT);
            this.Name = "NoiDaoTao";
            this.Text = "Quản lí nơi đào tạo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadNoiDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNoiDT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditNoiDT;
        private System.Windows.Forms.Button btnDelNoiDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenKhoa;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadNoiDT;
    }
}