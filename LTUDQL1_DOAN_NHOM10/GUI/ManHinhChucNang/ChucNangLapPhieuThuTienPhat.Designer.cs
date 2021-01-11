namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangLapPhieuThuTienPhat
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.txtNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.dgvDSDocGiaNo = new System.Windows.Forms.DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDocGiaNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(515, 309);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 39);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(205, 309);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(147, 42);
            this.btnXacNhan.TabIndex = 25;
            this.btnXacNhan.Text = "Hoàn tất";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số tiền thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày lập:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(461, 180);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(153, 25);
            this.lb5.TabIndex = 24;
            this.lb5.Text = "Người lập phiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số tiền nợ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã phiếu trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã độc giả:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(170, 234);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(224, 22);
            this.dtpNgayLap.TabIndex = 18;
            // 
            // txtTienThu
            // 
            this.txtTienThu.Location = new System.Drawing.Point(649, 234);
            this.txtTienThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(212, 22);
            this.txtTienThu.TabIndex = 13;
            // 
            // txtNguoiLapPhieu
            // 
            this.txtNguoiLapPhieu.Location = new System.Drawing.Point(649, 183);
            this.txtNguoiLapPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNguoiLapPhieu.Name = "txtNguoiLapPhieu";
            this.txtNguoiLapPhieu.Size = new System.Drawing.Size(212, 22);
            this.txtNguoiLapPhieu.TabIndex = 14;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(170, 183);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(224, 22);
            this.txtMaPT.TabIndex = 15;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(649, 131);
            this.txtTienNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(212, 22);
            this.txtTienNo.TabIndex = 16;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(170, 131);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(224, 22);
            this.txtMaDG.TabIndex = 17;
            // 
            // dgvDSDocGiaNo
            // 
            this.dgvDSDocGiaNo.AllowUserToAddRows = false;
            this.dgvDSDocGiaNo.AllowUserToDeleteRows = false;
            this.dgvDSDocGiaNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDocGiaNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDocGiaNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.TienNo,
            this.MaDG});
            this.dgvDSDocGiaNo.Location = new System.Drawing.Point(50, 380);
            this.dgvDSDocGiaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSDocGiaNo.Name = "dgvDSDocGiaNo";
            this.dgvDSDocGiaNo.ReadOnly = true;
            this.dgvDSDocGiaNo.RowHeadersVisible = false;
            this.dgvDSDocGiaNo.RowHeadersWidth = 51;
            this.dgvDSDocGiaNo.RowTemplate.Height = 24;
            this.dgvDSDocGiaNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDocGiaNo.Size = new System.Drawing.Size(812, 228);
            this.dgvDSDocGiaNo.TabIndex = 12;
            this.dgvDSDocGiaNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDocGiaNo_CellClick);
            // 
            // MaPT
            // 
            this.MaPT.DataPropertyName = "MaPT";
            this.MaPT.HeaderText = "Mã phiếu trả";
            this.MaPT.MinimumWidth = 6;
            this.MaPT.Name = "MaPT";
            this.MaPT.ReadOnly = true;
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "TienNo";
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.MinimumWidth = 6;
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Mã độc giả";
            this.MaDG.MinimumWidth = 6;
            this.MaDG.Name = "MaDG";
            this.MaDG.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "MÀN HÌNH CHỨC NĂNG LẬP PHIẾU THU TIỀN PHẠT";
            // 
            // ManHinhChucNangLapPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txtTienThu);
            this.Controls.Add(this.txtNguoiLapPhieu);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.dgvDSDocGiaNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChucNangLapPhieuThuTienPhat";
            this.Size = new System.Drawing.Size(907, 652);
            this.Load += new System.EventHandler(this.ManHinhChucNangLapPhieuThuTienPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDocGiaNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.TextBox txtNguoiLapPhieu;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.DataGridView dgvDSDocGiaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.Label label1;
    }
}
