namespace QuanLiDaoTao
{
    partial class ChiTietHTDT
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelNDT = new System.Windows.Forms.Button();
            this.btnEditNDT = new System.Windows.Forms.Button();
            this.btnAddNDK = new System.Windows.Forms.Button();
            this.dgvNDT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaNDT = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDelNDT);
            this.groupBox2.Controls.Add(this.btnEditNDT);
            this.groupBox2.Controls.Add(this.btnAddNDK);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 146);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(11, 104);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(166, 36);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelNDT
            // 
            this.btnDelNDT.Location = new System.Drawing.Point(97, 62);
            this.btnDelNDT.Name = "btnDelNDT";
            this.btnDelNDT.Size = new System.Drawing.Size(75, 28);
            this.btnDelNDT.TabIndex = 2;
            this.btnDelNDT.Text = "Xóa";
            this.btnDelNDT.UseVisualStyleBackColor = true;
            // 
            // btnEditNDT
            // 
            this.btnEditNDT.Location = new System.Drawing.Point(97, 24);
            this.btnEditNDT.Name = "btnEditNDT";
            this.btnEditNDT.Size = new System.Drawing.Size(75, 32);
            this.btnEditNDT.TabIndex = 1;
            this.btnEditNDT.Text = "Sửa";
            this.btnEditNDT.UseVisualStyleBackColor = true;
            // 
            // btnAddNDK
            // 
            this.btnAddNDK.Location = new System.Drawing.Point(11, 24);
            this.btnAddNDK.Name = "btnAddNDK";
            this.btnAddNDK.Size = new System.Drawing.Size(75, 66);
            this.btnAddNDK.TabIndex = 0;
            this.btnAddNDK.Text = "Thêm";
            this.btnAddNDK.UseVisualStyleBackColor = true;
            // 
            // dgvNDT
            // 
            this.dgvNDT.AllowUserToAddRows = false;
            this.dgvNDT.AllowUserToDeleteRows = false;
            this.dgvNDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNDT.Location = new System.Drawing.Point(12, 175);
            this.dgvNDT.Name = "dgvNDT";
            this.dgvNDT.Size = new System.Drawing.Size(557, 126);
            this.dgvNDT.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMaNDT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngành đào tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã ngành";
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
            // txbMaNDT
            // 
            this.txbMaNDT.Location = new System.Drawing.Point(159, 41);
            this.txbMaNDT.Name = "txbMaNDT";
            this.txbMaNDT.Size = new System.Drawing.Size(177, 20);
            this.txbMaNDT.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(159, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã hình thức đào tạo";
            // 
            // ChiTietHTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNDT);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietHTDT";
            this.Text = "Quản lí chi tiết hình thức đào tạo";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelNDT;
        private System.Windows.Forms.Button btnEditNDT;
        private System.Windows.Forms.Button btnAddNDK;
        private System.Windows.Forms.DataGridView dgvNDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNDT;
    }
}