namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangNhanTraSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dtgrPhieuTra = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.txtTienPhatKyNay = new System.Windows.Forms.TextBox();
            this.txtLoaiDG = new System.Windows.Forms.TextBox();
            this.txtNgaySinhDG = new System.Windows.Forms.TextBox();
            this.txtHoTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtMaPhieuTra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPhieuTra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(705, 583);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 47);
            this.btnThoat.TabIndex = 52;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.Location = new System.Drawing.Point(518, 583);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(149, 47);
            this.btnLapPhieu.TabIndex = 51;
            this.btnLapPhieu.Text = "Lập Phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dtgrPhieuTra
            // 
            this.dtgrPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.NgayMuon,
            this.SoNgayMuon,
            this.TienPhat});
            this.dtgrPhieuTra.Location = new System.Drawing.Point(66, 349);
            this.dtgrPhieuTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrPhieuTra.Name = "dtgrPhieuTra";
            this.dtgrPhieuTra.RowHeadersVisible = false;
            this.dtgrPhieuTra.RowHeadersWidth = 51;
            this.dtgrPhieuTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgrPhieuTra.Size = new System.Drawing.Size(777, 208);
            this.dtgrPhieuTra.TabIndex = 50;
            this.dtgrPhieuTra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrPhieuTra_CellDoubleClick);
            this.dtgrPhieuTra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrPhieuTra_CellEndEdit);
            this.dtgrPhieuTra.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgrPhieuTra_RowsAdded);
            this.dtgrPhieuTra.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgrPhieuTra_RowsRemoved);
            // 
            // STT
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.NullValue = "1";
            this.STT.DefaultCellStyle = dataGridViewCellStyle5;
            this.STT.FillWeight = 50.76142F;
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
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NgayMuon.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayMuon.FillWeight = 112.3096F;
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // SoNgayMuon
            // 
            this.SoNgayMuon.DataPropertyName = "SoNgayMuon";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SoNgayMuon.DefaultCellStyle = dataGridViewCellStyle7;
            this.SoNgayMuon.FillWeight = 112.3096F;
            this.SoNgayMuon.HeaderText = "Số ngày mượn";
            this.SoNgayMuon.MinimumWidth = 6;
            this.SoNgayMuon.Name = "SoNgayMuon";
            this.SoNgayMuon.ReadOnly = true;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "TienPhat";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TienPhat.DefaultCellStyle = dataGridViewCellStyle8;
            this.TienPhat.FillWeight = 112.3096F;
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.MinimumWidth = 6;
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(656, 93);
            this.dtNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(187, 22);
            this.dtNgayTra.TabIndex = 49;
            this.dtNgayTra.ValueChanged += new System.EventHandler(this.dtNgayTra_ValueChanged);
            // 
            // txtTongNo
            // 
            this.txtTongNo.Location = new System.Drawing.Point(253, 281);
            this.txtTongNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(169, 22);
            this.txtTongNo.TabIndex = 48;
            this.txtTongNo.Text = "0";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(656, 238);
            this.txtTienNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.ReadOnly = true;
            this.txtTienNo.Size = new System.Drawing.Size(187, 22);
            this.txtTienNo.TabIndex = 47;
            this.txtTienNo.Text = "0";
            // 
            // txtTienPhatKyNay
            // 
            this.txtTienPhatKyNay.Location = new System.Drawing.Point(253, 238);
            this.txtTienPhatKyNay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienPhatKyNay.Name = "txtTienPhatKyNay";
            this.txtTienPhatKyNay.ReadOnly = true;
            this.txtTienPhatKyNay.Size = new System.Drawing.Size(169, 22);
            this.txtTienPhatKyNay.TabIndex = 46;
            this.txtTienPhatKyNay.Text = "0";
            // 
            // txtLoaiDG
            // 
            this.txtLoaiDG.Location = new System.Drawing.Point(656, 188);
            this.txtLoaiDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiDG.Name = "txtLoaiDG";
            this.txtLoaiDG.ReadOnly = true;
            this.txtLoaiDG.Size = new System.Drawing.Size(187, 22);
            this.txtLoaiDG.TabIndex = 45;
            // 
            // txtNgaySinhDG
            // 
            this.txtNgaySinhDG.Location = new System.Drawing.Point(253, 190);
            this.txtNgaySinhDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinhDG.Name = "txtNgaySinhDG";
            this.txtNgaySinhDG.ReadOnly = true;
            this.txtNgaySinhDG.Size = new System.Drawing.Size(169, 22);
            this.txtNgaySinhDG.TabIndex = 44;
            // 
            // txtHoTenDG
            // 
            this.txtHoTenDG.Location = new System.Drawing.Point(656, 146);
            this.txtHoTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenDG.Name = "txtHoTenDG";
            this.txtHoTenDG.ReadOnly = true;
            this.txtHoTenDG.Size = new System.Drawing.Size(187, 22);
            this.txtHoTenDG.TabIndex = 43;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(253, 146);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(169, 22);
            this.txtMaDG.TabIndex = 42;
            this.txtMaDG.Leave += new System.EventHandler(this.txtMaDG_Leave);
            // 
            // txtMaPhieuTra
            // 
            this.txtMaPhieuTra.Location = new System.Drawing.Point(253, 97);
            this.txtMaPhieuTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuTra.Name = "txtMaPhieuTra";
            this.txtMaPhieuTra.ReadOnly = true;
            this.txtMaPhieuTra.Size = new System.Drawing.Size(169, 22);
            this.txtMaPhieuTra.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(476, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Loại độc giả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(476, 242);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tiền nợ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(62, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tiền phạt kỳ này:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(62, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tổng nợ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(62, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã độc giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(476, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Họ tên độc giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(62, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(476, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngày trả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(62, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã phiếu trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "PHIẾU TRẢ SÁCH ";
            // 
            // ManHinhChucNangNhanTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.dtgrPhieuTra);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.txtTongNo);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.txtTienPhatKyNay);
            this.Controls.Add(this.txtLoaiDG);
            this.Controls.Add(this.txtNgaySinhDG);
            this.Controls.Add(this.txtHoTenDG);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.txtMaPhieuTra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChucNangNhanTraSach";
            this.Size = new System.Drawing.Size(907, 652);
            this.Load += new System.EventHandler(this.ManHinhChucNangNhanTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPhieuTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridView dtgrPhieuTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.TextBox txtTienPhatKyNay;
        private System.Windows.Forms.TextBox txtLoaiDG;
        private System.Windows.Forms.TextBox txtNgaySinhDG;
        private System.Windows.Forms.TextBox txtHoTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.TextBox txtMaPhieuTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
