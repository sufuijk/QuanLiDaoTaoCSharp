namespace QuanLiDaoTao
{
    partial class HinhThucDaoTao
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
            this.btnAddHTDT = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditHTDT = new System.Windows.Forms.Button();
            this.btnDelHTDT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTenHTDT = new System.Windows.Forms.TextBox();
            this.txbMaHTDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoadHTDT = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadHTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddHTDT);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnEditHTDT);
            this.groupBox2.Controls.Add(this.btnDelHTDT);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnAddHTDT
            // 
            this.btnAddHTDT.Location = new System.Drawing.Point(6, 27);
            this.btnAddHTDT.Name = "btnAddHTDT";
            this.btnAddHTDT.Size = new System.Drawing.Size(75, 56);
            this.btnAddHTDT.TabIndex = 2;
            this.btnAddHTDT.Text = "Thêm";
            this.btnAddHTDT.UseVisualStyleBackColor = true;
            this.btnAddHTDT.Click += new System.EventHandler(this.btnAddHTDT_Click);
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
            // btnEditHTDT
            // 
            this.btnEditHTDT.Location = new System.Drawing.Point(119, 27);
            this.btnEditHTDT.Name = "btnEditHTDT";
            this.btnEditHTDT.Size = new System.Drawing.Size(75, 23);
            this.btnEditHTDT.TabIndex = 3;
            this.btnEditHTDT.Text = "Sửa";
            this.btnEditHTDT.UseVisualStyleBackColor = true;
            this.btnEditHTDT.Click += new System.EventHandler(this.btnEditHTDT_Click);
            // 
            // btnDelHTDT
            // 
            this.btnDelHTDT.Location = new System.Drawing.Point(119, 60);
            this.btnDelHTDT.Name = "btnDelHTDT";
            this.btnDelHTDT.Size = new System.Drawing.Size(75, 23);
            this.btnDelHTDT.TabIndex = 4;
            this.btnDelHTDT.Text = "Xóa";
            this.btnDelHTDT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTenHTDT);
            this.groupBox1.Controls.Add(this.txbMaHTDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hình thức đào tạo";
            // 
            // txbTenHTDT
            // 
            this.txbTenHTDT.Location = new System.Drawing.Point(138, 67);
            this.txbTenHTDT.Name = "txbTenHTDT";
            this.txbTenHTDT.Size = new System.Drawing.Size(181, 20);
            this.txbTenHTDT.TabIndex = 3;
            // 
            // txbMaHTDT
            // 
            this.txbMaHTDT.Location = new System.Drawing.Point(138, 32);
            this.txbMaHTDT.Name = "txbMaHTDT";
            this.txbMaHTDT.Size = new System.Drawing.Size(181, 20);
            this.txbMaHTDT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hình thức đào tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hình thức đào tạo";
            // 
            // dgvLoadHTDT
            // 
            this.dgvLoadHTDT.AllowUserToAddRows = false;
            this.dgvLoadHTDT.AllowUserToDeleteRows = false;
            this.dgvLoadHTDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoadHTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadHTDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoadHTDT.Location = new System.Drawing.Point(0, 173);
            this.dgvLoadHTDT.Name = "dgvLoadHTDT";
            this.dgvLoadHTDT.ReadOnly = true;
            this.dgvLoadHTDT.Size = new System.Drawing.Size(595, 135);
            this.dgvLoadHTDT.TabIndex = 10;
            this.dgvLoadHTDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadHTDT_CellClick);
            // 
            // HinhThucDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadHTDT);
            this.Name = "HinhThucDaoTao";
            this.Text = "Hình Thức Đào Tạo";
            this.Load += new System.EventHandler(this.HinhThucDaoTao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadHTDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddHTDT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEditHTDT;
        private System.Windows.Forms.Button btnDelHTDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenHTDT;
        private System.Windows.Forms.TextBox txbMaHTDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadHTDT;
    }
}