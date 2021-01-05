namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangQuanLyDocGia
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
            this.dgvDanhSachDocGia = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVLapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachDocGia
            // 
            this.dgvDanhSachDocGia.AllowUserToAddRows = false;
            this.dgvDanhSachDocGia.AllowUserToDeleteRows = false;
            this.dgvDanhSachDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.HoTenDG,
            this.DiaChi,
            this.NgaySinh,
            this.Email,
            this.NVLapThe,
            this.NgayLapThe,
            this.NgayHetHan,
            this.TongNo});
            this.dgvDanhSachDocGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachDocGia.Location = new System.Drawing.Point(0, 98);
            this.dgvDanhSachDocGia.Name = "dgvDanhSachDocGia";
            this.dgvDanhSachDocGia.RowHeadersVisible = false;
            this.dgvDanhSachDocGia.RowHeadersWidth = 51;
            this.dgvDanhSachDocGia.RowTemplate.Height = 24;
            this.dgvDanhSachDocGia.Size = new System.Drawing.Size(907, 554);
            this.dgvDanhSachDocGia.TabIndex = 9;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // HoTenDG
            // 
            this.HoTenDG.DataPropertyName = "HoTenDG";
            this.HoTenDG.HeaderText = "Họ Tên";
            this.HoTenDG.MinimumWidth = 6;
            this.HoTenDG.Name = "HoTenDG";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // NVLapThe
            // 
            this.NVLapThe.DataPropertyName = "NVLapThe";
            this.NVLapThe.HeaderText = "Nhân Viên Lập Thẻ";
            this.NVLapThe.MinimumWidth = 6;
            this.NVLapThe.Name = "NVLapThe";
            // 
            // NgayLapThe
            // 
            this.NgayLapThe.DataPropertyName = "NgayLapThe";
            this.NgayLapThe.HeaderText = "Ngày Lập Thẻ";
            this.NgayLapThe.MinimumWidth = 6;
            this.NgayLapThe.Name = "NgayLapThe";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // TongNo
            // 
            this.TongNo.DataPropertyName = "TongNo";
            this.TongNo.HeaderText = "Tổng Nợ";
            this.TongNo.MinimumWidth = 6;
            this.TongNo.Name = "TongNo";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(656, 50);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 40);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(783, 50);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 40);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // ManHinhChucNangQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDanhSachDocGia);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Name = "ManHinhChucNangQuanLyDocGia";
            this.Size = new System.Drawing.Size(907, 652);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVLapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}
