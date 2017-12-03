namespace QuanLiDaoTao
{
    partial class Khoa
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
            this.dgvLoadKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddKhoa = new System.Windows.Forms.Button();
            this.btnEditKhoa = new System.Windows.Forms.Button();
            this.btnDelKhoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoadKhoa
            // 
            this.dgvLoadKhoa.AllowUserToAddRows = false;
            this.dgvLoadKhoa.AllowUserToDeleteRows = false;
            this.dgvLoadKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadKhoa.Location = new System.Drawing.Point(12, 140);
            this.dgvLoadKhoa.Name = "dgvLoadKhoa";
            this.dgvLoadKhoa.ReadOnly = true;
            this.dgvLoadKhoa.Size = new System.Drawing.Size(569, 161);
            this.dgvLoadKhoa.TabIndex = 0;
            this.dgvLoadKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadKhoa_CellClick);
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
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Location = new System.Drawing.Point(90, 67);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(229, 20);
            this.txbTenKhoa.TabIndex = 3;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(90, 32);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(229, 20);
            this.txbMaKhoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // btnAddKhoa
            // 
            this.btnAddKhoa.Location = new System.Drawing.Point(6, 27);
            this.btnAddKhoa.Name = "btnAddKhoa";
            this.btnAddKhoa.Size = new System.Drawing.Size(75, 56);
            this.btnAddKhoa.TabIndex = 2;
            this.btnAddKhoa.Text = "Thêm";
            this.btnAddKhoa.UseVisualStyleBackColor = true;
            this.btnAddKhoa.Click += new System.EventHandler(this.btnAddKhoa_Click);
            // 
            // btnEditKhoa
            // 
            this.btnEditKhoa.Location = new System.Drawing.Point(119, 27);
            this.btnEditKhoa.Name = "btnEditKhoa";
            this.btnEditKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnEditKhoa.TabIndex = 3;
            this.btnEditKhoa.Text = "Sửa";
            this.btnEditKhoa.UseVisualStyleBackColor = true;
            this.btnEditKhoa.Click += new System.EventHandler(this.btnEditKhoa_Click);
            // 
            // btnDelKhoa
            // 
            this.btnDelKhoa.Location = new System.Drawing.Point(119, 60);
            this.btnDelKhoa.Name = "btnDelKhoa";
            this.btnDelKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnDelKhoa.TabIndex = 4;
            this.btnDelKhoa.Text = "Xóa";
            this.btnDelKhoa.UseVisualStyleBackColor = true;
            this.btnDelKhoa.Click += new System.EventHandler(this.btnDelKhoa_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddKhoa);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnEditKhoa);
            this.groupBox2.Controls.Add(this.btnDelKhoa);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadKhoa);
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenKhoa;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddKhoa;
        private System.Windows.Forms.Button btnEditKhoa;
        private System.Windows.Forms.Button btnDelKhoa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}