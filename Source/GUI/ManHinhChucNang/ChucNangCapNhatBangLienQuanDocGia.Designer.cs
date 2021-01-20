namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangCapNhatBangLienQuanDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLoaiDocGia = new System.Windows.Forms.DataGridView();
            this.MaLoaiDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaLoaiDG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenLoaiDG = new System.Windows.Forms.TextBox();
            this.btnXoaLoaiDG = new System.Windows.Forms.Button();
            this.btnSuaLoaiDG = new System.Windows.Forms.Button();
            this.btnThemLoaiDG = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTinhTrangDG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTinhTrangDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaTinhTrangDG = new System.Windows.Forms.Button();
            this.btnSuaTinhTrangDG = new System.Windows.Forms.Button();
            this.dgvTinhTrangDG = new System.Windows.Forms.DataGridView();
            this.MaTinhTrangDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTinhTrangDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTinhTrangDG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "CẬP NHẬT CÁC QUY ĐỊNH LIÊN QUAN ĐẾN ĐỘC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Loại độc giả";
            // 
            // dgvLoaiDocGia
            // 
            this.dgvLoaiDocGia.AllowUserToAddRows = false;
            this.dgvLoaiDocGia.AllowUserToDeleteRows = false;
            this.dgvLoaiDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiDG,
            this.TenLoaiDG});
            this.dgvLoaiDocGia.Location = new System.Drawing.Point(8, 102);
            this.dgvLoaiDocGia.Name = "dgvLoaiDocGia";
            this.dgvLoaiDocGia.ReadOnly = true;
            this.dgvLoaiDocGia.RowHeadersVisible = false;
            this.dgvLoaiDocGia.RowHeadersWidth = 51;
            this.dgvLoaiDocGia.RowTemplate.Height = 24;
            this.dgvLoaiDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDocGia.Size = new System.Drawing.Size(384, 248);
            this.dgvLoaiDocGia.TabIndex = 76;
            this.dgvLoaiDocGia.SelectionChanged += new System.EventHandler(this.dgvLoaiDocGia_SelectionChanged);
            // 
            // MaLoaiDG
            // 
            this.MaLoaiDG.DataPropertyName = "MaLoaiDG";
            this.MaLoaiDG.HeaderText = "Mã Loại Độc Giả";
            this.MaLoaiDG.MinimumWidth = 6;
            this.MaLoaiDG.Name = "MaLoaiDG";
            this.MaLoaiDG.ReadOnly = true;
            // 
            // TenLoaiDG
            // 
            this.TenLoaiDG.DataPropertyName = "TenLoaiDG";
            this.TenLoaiDG.HeaderText = "Loại Độc Giả";
            this.TenLoaiDG.MinimumWidth = 6;
            this.TenLoaiDG.Name = "TenLoaiDG";
            this.TenLoaiDG.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Mã Loại Độc Giả";
            // 
            // txtMaLoaiDG
            // 
            this.txtMaLoaiDG.Enabled = false;
            this.txtMaLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiDG.Location = new System.Drawing.Point(393, 102);
            this.txtMaLoaiDG.Name = "txtMaLoaiDG";
            this.txtMaLoaiDG.Size = new System.Drawing.Size(257, 30);
            this.txtMaLoaiDG.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Tên Loại Độc Giả";
            // 
            // txtTenLoaiDG
            // 
            this.txtTenLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiDG.Location = new System.Drawing.Point(656, 102);
            this.txtTenLoaiDG.Name = "txtTenLoaiDG";
            this.txtTenLoaiDG.Size = new System.Drawing.Size(248, 30);
            this.txtTenLoaiDG.TabIndex = 83;
            // 
            // btnXoaLoaiDG
            // 
            this.btnXoaLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiDG.Location = new System.Drawing.Point(742, 148);
            this.btnXoaLoaiDG.Name = "btnXoaLoaiDG";
            this.btnXoaLoaiDG.Size = new System.Drawing.Size(162, 43);
            this.btnXoaLoaiDG.TabIndex = 82;
            this.btnXoaLoaiDG.Text = "Xóa Loại Độc Giả";
            this.btnXoaLoaiDG.UseVisualStyleBackColor = true;
            this.btnXoaLoaiDG.Click += new System.EventHandler(this.btnXoaLoaiDG_Click);
            // 
            // btnSuaLoaiDG
            // 
            this.btnSuaLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiDG.Location = new System.Drawing.Point(573, 148);
            this.btnSuaLoaiDG.Name = "btnSuaLoaiDG";
            this.btnSuaLoaiDG.Size = new System.Drawing.Size(163, 43);
            this.btnSuaLoaiDG.TabIndex = 81;
            this.btnSuaLoaiDG.Text = "Sửa Loại Độc Giả";
            this.btnSuaLoaiDG.UseVisualStyleBackColor = true;
            this.btnSuaLoaiDG.Click += new System.EventHandler(this.btnSuaLoaiDG_Click);
            // 
            // btnThemLoaiDG
            // 
            this.btnThemLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiDG.Location = new System.Drawing.Point(393, 148);
            this.btnThemLoaiDG.Name = "btnThemLoaiDG";
            this.btnThemLoaiDG.Size = new System.Drawing.Size(174, 43);
            this.btnThemLoaiDG.TabIndex = 80;
            this.btnThemLoaiDG.Text = "Thêm Loại Độc Giả";
            this.btnThemLoaiDG.UseVisualStyleBackColor = true;
            this.btnThemLoaiDG.Click += new System.EventHandler(this.btnThemLoaiDG_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Mã Tình Trạng Độc Giả";
            // 
            // txtMaTinhTrangDG
            // 
            this.txtMaTinhTrangDG.Enabled = false;
            this.txtMaTinhTrangDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTinhTrangDG.Location = new System.Drawing.Point(395, 395);
            this.txtMaTinhTrangDG.Name = "txtMaTinhTrangDG";
            this.txtMaTinhTrangDG.Size = new System.Drawing.Size(257, 30);
            this.txtMaTinhTrangDG.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Tên Tình Trạng Độc Giả";
            // 
            // txtTenTinhTrangDG
            // 
            this.txtTenTinhTrangDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTinhTrangDG.Location = new System.Drawing.Point(656, 395);
            this.txtTenTinhTrangDG.Name = "txtTenTinhTrangDG";
            this.txtTenTinhTrangDG.Size = new System.Drawing.Size(248, 30);
            this.txtTenTinhTrangDG.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(8, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tình trạng";
            // 
            // btnXoaTinhTrangDG
            // 
            this.btnXoaTinhTrangDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTinhTrangDG.Location = new System.Drawing.Point(742, 431);
            this.btnXoaTinhTrangDG.Name = "btnXoaTinhTrangDG";
            this.btnXoaTinhTrangDG.Size = new System.Drawing.Size(162, 62);
            this.btnXoaTinhTrangDG.TabIndex = 90;
            this.btnXoaTinhTrangDG.Text = "Xóa Tình Trạng Độc Giả";
            this.btnXoaTinhTrangDG.UseVisualStyleBackColor = true;
            this.btnXoaTinhTrangDG.Click += new System.EventHandler(this.btnXoaTinhTrangDG_Click);
            // 
            // btnSuaTinhTrangDG
            // 
            this.btnSuaTinhTrangDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTinhTrangDG.Location = new System.Drawing.Point(573, 431);
            this.btnSuaTinhTrangDG.Name = "btnSuaTinhTrangDG";
            this.btnSuaTinhTrangDG.Size = new System.Drawing.Size(163, 62);
            this.btnSuaTinhTrangDG.TabIndex = 89;
            this.btnSuaTinhTrangDG.Text = "Sửa Tình Trạng Độc Giả";
            this.btnSuaTinhTrangDG.UseVisualStyleBackColor = true;
            this.btnSuaTinhTrangDG.Click += new System.EventHandler(this.btnSuaTinhTrangDG_Click);
            // 
            // dgvTinhTrangDG
            // 
            this.dgvTinhTrangDG.AllowUserToAddRows = false;
            this.dgvTinhTrangDG.AllowUserToDeleteRows = false;
            this.dgvTinhTrangDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTrangDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrangDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTinhTrangDG,
            this.LoaiTinhTrangDG});
            this.dgvTinhTrangDG.Location = new System.Drawing.Point(8, 395);
            this.dgvTinhTrangDG.Name = "dgvTinhTrangDG";
            this.dgvTinhTrangDG.ReadOnly = true;
            this.dgvTinhTrangDG.RowHeadersVisible = false;
            this.dgvTinhTrangDG.RowHeadersWidth = 51;
            this.dgvTinhTrangDG.RowTemplate.Height = 24;
            this.dgvTinhTrangDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTinhTrangDG.Size = new System.Drawing.Size(384, 254);
            this.dgvTinhTrangDG.TabIndex = 88;
            this.dgvTinhTrangDG.SelectionChanged += new System.EventHandler(this.dgvTinhTrangDG_SelectionChanged);
            // 
            // MaTinhTrangDG
            // 
            this.MaTinhTrangDG.DataPropertyName = "MaTinhTrangDG";
            this.MaTinhTrangDG.HeaderText = "Mã Tình Trạng";
            this.MaTinhTrangDG.MinimumWidth = 6;
            this.MaTinhTrangDG.Name = "MaTinhTrangDG";
            this.MaTinhTrangDG.ReadOnly = true;
            // 
            // LoaiTinhTrangDG
            // 
            this.LoaiTinhTrangDG.DataPropertyName = "LoaiTinhTrangDG";
            this.LoaiTinhTrangDG.HeaderText = "Tình Trạng";
            this.LoaiTinhTrangDG.MinimumWidth = 6;
            this.LoaiTinhTrangDG.Name = "LoaiTinhTrangDG";
            this.LoaiTinhTrangDG.ReadOnly = true;
            // 
            // btnThemTinhTrangDG
            // 
            this.btnThemTinhTrangDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTinhTrangDG.Location = new System.Drawing.Point(395, 431);
            this.btnThemTinhTrangDG.Name = "btnThemTinhTrangDG";
            this.btnThemTinhTrangDG.Size = new System.Drawing.Size(174, 62);
            this.btnThemTinhTrangDG.TabIndex = 87;
            this.btnThemTinhTrangDG.Text = "Thêm Tình Trạng Độc Giả";
            this.btnThemTinhTrangDG.UseVisualStyleBackColor = true;
            this.btnThemTinhTrangDG.Click += new System.EventHandler(this.btnThemTinhTrangDG_Click);
            // 
            // ManHinhChucNangCapNhatBangLienQuanDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaTinhTrangDG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenTinhTrangDG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaTinhTrangDG);
            this.Controls.Add(this.btnSuaTinhTrangDG);
            this.Controls.Add(this.dgvTinhTrangDG);
            this.Controls.Add(this.btnThemTinhTrangDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaLoaiDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenLoaiDG);
            this.Controls.Add(this.btnXoaLoaiDG);
            this.Controls.Add(this.btnSuaLoaiDG);
            this.Controls.Add(this.btnThemLoaiDG);
            this.Controls.Add(this.dgvLoaiDocGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManHinhChucNangCapNhatBangLienQuanDocGia";
            this.Size = new System.Drawing.Size(907, 652);
            this.Load += new System.EventHandler(this.ManHinhChucNangCapNhatBangLienQuanDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaLoaiDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenLoaiDG;
        private System.Windows.Forms.Button btnXoaLoaiDG;
        private System.Windows.Forms.Button btnSuaLoaiDG;
        private System.Windows.Forms.Button btnThemLoaiDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTinhTrangDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTinhTrangDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaTinhTrangDG;
        private System.Windows.Forms.Button btnSuaTinhTrangDG;
        private System.Windows.Forms.DataGridView dgvTinhTrangDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTinhTrangDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTinhTrangDG;
        private System.Windows.Forms.Button btnThemTinhTrangDG;
    }
}
