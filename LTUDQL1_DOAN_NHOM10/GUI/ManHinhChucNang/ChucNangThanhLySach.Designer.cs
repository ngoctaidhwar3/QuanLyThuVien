namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangThanhLySach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnWrapperThanhLySach = new System.Windows.Forms.Panel();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.dtNgayThanhLy = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.dgvChiTietPhieuThanhLy = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoThanhLy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnWrapperThanhLySach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuThanhLy)).BeginInit();
            this.SuspendLayout();
            // 
            // pnWrapperThanhLySach
            // 
            this.pnWrapperThanhLySach.Controls.Add(this.cbbNhanVien);
            this.pnWrapperThanhLySach.Controls.Add(this.dtNgayThanhLy);
            this.pnWrapperThanhLySach.Controls.Add(this.btnThoat);
            this.pnWrapperThanhLySach.Controls.Add(this.btnHoanTat);
            this.pnWrapperThanhLySach.Controls.Add(this.dgvChiTietPhieuThanhLy);
            this.pnWrapperThanhLySach.Controls.Add(this.txtNgaySinh);
            this.pnWrapperThanhLySach.Controls.Add(this.label7);
            this.pnWrapperThanhLySach.Controls.Add(this.label5);
            this.pnWrapperThanhLySach.Controls.Add(this.label3);
            this.pnWrapperThanhLySach.Controls.Add(this.txtMaPhieu);
            this.pnWrapperThanhLySach.Controls.Add(this.label2);
            this.pnWrapperThanhLySach.Controls.Add(this.btnLamMoi);
            this.pnWrapperThanhLySach.Controls.Add(this.label1);
            this.pnWrapperThanhLySach.Location = new System.Drawing.Point(0, 0);
            this.pnWrapperThanhLySach.Margin = new System.Windows.Forms.Padding(4);
            this.pnWrapperThanhLySach.Name = "pnWrapperThanhLySach";
            this.pnWrapperThanhLySach.Size = new System.Drawing.Size(903, 652);
            this.pnWrapperThanhLySach.TabIndex = 1;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(201, 168);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(228, 34);
            this.cbbNhanVien.TabIndex = 53;
            this.cbbNhanVien.SelectedValueChanged += new System.EventHandler(this.cbbNhanVien_SelectedValueChanged);
            // 
            // dtNgayThanhLy
            // 
            this.dtNgayThanhLy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayThanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThanhLy.Location = new System.Drawing.Point(653, 90);
            this.dtNgayThanhLy.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayThanhLy.Name = "dtNgayThanhLy";
            this.dtNgayThanhLy.Size = new System.Drawing.Size(228, 38);
            this.dtNgayThanhLy.TabIndex = 52;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(637, 591);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Location = new System.Drawing.Point(405, 591);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(100, 46);
            this.btnHoanTat.TabIndex = 50;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // dgvChiTietPhieuThanhLy
            // 
            this.dgvChiTietPhieuThanhLy.AllowUserToResizeColumns = false;
            this.dgvChiTietPhieuThanhLy.AllowUserToResizeRows = false;
            this.dgvChiTietPhieuThanhLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietPhieuThanhLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietPhieuThanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuThanhLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.LyDoThanhLy,
            this.TenSach,
            this.TheLoai,
            this.TacGia});
            this.dgvChiTietPhieuThanhLy.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvChiTietPhieuThanhLy.Location = new System.Drawing.Point(29, 225);
            this.dgvChiTietPhieuThanhLy.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietPhieuThanhLy.MultiSelect = false;
            this.dgvChiTietPhieuThanhLy.Name = "dgvChiTietPhieuThanhLy";
            this.dgvChiTietPhieuThanhLy.RowHeadersVisible = false;
            this.dgvChiTietPhieuThanhLy.RowHeadersWidth = 51;
            this.dgvChiTietPhieuThanhLy.Size = new System.Drawing.Size(853, 359);
            this.dgvChiTietPhieuThanhLy.TabIndex = 49;
            // 
            // STT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.FillWeight = 50.76143F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 112.3096F;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            // 
            // LyDoThanhLy
            // 
            this.LyDoThanhLy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.LyDoThanhLy.HeaderText = "Lý do thanh lý";
            this.LyDoThanhLy.MinimumWidth = 6;
            this.LyDoThanhLy.Name = "LyDoThanhLy";
            // 
            // TenSach
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TenSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenSach.FillWeight = 112.3096F;
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TheLoai
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TheLoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.TheLoai.FillWeight = 112.3096F;
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // TacGia
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TacGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.TacGia.FillWeight = 112.3096F;
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(653, 171);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(228, 32);
            this.txtNgaySinh.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 26);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày thanh lý:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(201, 98);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(228, 32);
            this.txtMaPhieu.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã phiếu:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(177, 591);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 46);
            this.btnLamMoi.TabIndex = 37;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "THANH LÝ SÁCH";
            // 
            // ManHinhChucNangThanhLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnWrapperThanhLySach);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChucNangThanhLySach";
            this.Size = new System.Drawing.Size(907, 652);
            this.Load += new System.EventHandler(this.ManHinhChucNangThanhLySach_Load);
            this.SizeChanged += new System.EventHandler(this.ManHinhChucNangThanhLySach_SizeChanged);
            this.pnWrapperThanhLySach.ResumeLayout(false);
            this.pnWrapperThanhLySach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuThanhLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWrapperThanhLySach;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.DateTimePicker dtNgayThanhLy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn LyDoThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
    }
}
