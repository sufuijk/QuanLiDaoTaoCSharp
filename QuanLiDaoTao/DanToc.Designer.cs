namespace QuanLiDaoTao
{
    partial class DanToc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanToc));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelDT = new System.Windows.Forms.Button();
            this.btnEditDT = new System.Windows.Forms.Button();
            this.btnAddDT = new System.Windows.Forms.Button();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenDT = new System.Windows.Forms.TextBox();
            this.txbMaDT = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDelDT);
            this.groupBox2.Controls.Add(this.btnEditDT);
            this.groupBox2.Controls.Add(this.btnAddDT);
            this.groupBox2.Location = new System.Drawing.Point(579, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(274, 187);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 133);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(249, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelDT
            // 
            this.btnDelDT.Location = new System.Drawing.Point(146, 83);
            this.btnDelDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDT.Name = "btnDelDT";
            this.btnDelDT.Size = new System.Drawing.Size(112, 41);
            this.btnDelDT.TabIndex = 2;
            this.btnDelDT.Text = "Xóa";
            this.btnDelDT.UseVisualStyleBackColor = true;
            this.btnDelDT.Click += new System.EventHandler(this.btnDelDT_Click);
            // 
            // btnEditDT
            // 
            this.btnEditDT.Location = new System.Drawing.Point(146, 28);
            this.btnEditDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDT.Name = "btnEditDT";
            this.btnEditDT.Size = new System.Drawing.Size(112, 47);
            this.btnEditDT.TabIndex = 1;
            this.btnEditDT.Text = "Sửa";
            this.btnEditDT.UseVisualStyleBackColor = true;
            this.btnEditDT.Click += new System.EventHandler(this.btnEditDT_Click);
            // 
            // btnAddDT
            // 
            this.btnAddDT.Location = new System.Drawing.Point(9, 28);
            this.btnAddDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDT.Name = "btnAddDT";
            this.btnAddDT.Size = new System.Drawing.Size(112, 96);
            this.btnAddDT.TabIndex = 0;
            this.btnAddDT.Text = "Thêm";
            this.btnAddDT.UseVisualStyleBackColor = true;
            this.btnAddDT.Click += new System.EventHandler(this.btnAddDT_Click);
            // 
            // dgvDT
            // 
            this.dgvDT.AllowUserToAddRows = false;
            this.dgvDT.AllowUserToDeleteRows = false;
            this.dgvDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDT.Location = new System.Drawing.Point(0, 227);
            this.dgvDT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.ReadOnly = true;
            this.dgvDT.Size = new System.Drawing.Size(866, 184);
            this.dgvDT.TabIndex = 3;
            this.dgvDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDT_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTenDT);
            this.groupBox1.Controls.Add(this.txbMaDT);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(552, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dân tộc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên dân tộc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã dân tộc";
            // 
            // txbTenDT
            // 
            this.txbTenDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDT.Location = new System.Drawing.Point(238, 105);
            this.txbTenDT.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenDT.Name = "txbTenDT";
            this.txbTenDT.Size = new System.Drawing.Size(264, 26);
            this.txbTenDT.TabIndex = 1;
            // 
            // txbMaDT
            // 
            this.txbMaDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaDT.Location = new System.Drawing.Point(238, 60);
            this.txbMaDT.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaDT.Name = "txbMaDT";
            this.txbMaDT.Size = new System.Drawing.Size(264, 26);
            this.txbMaDT.TabIndex = 0;
            // 
            // DanToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDT);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanToc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dân tộc";
            this.Load += new System.EventHandler(this.DanToc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelDT;
        private System.Windows.Forms.Button btnEditDT;
        private System.Windows.Forms.Button btnAddDT;
        private System.Windows.Forms.DataGridView dgvDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenDT;
        private System.Windows.Forms.TextBox txbMaDT;
    }
}