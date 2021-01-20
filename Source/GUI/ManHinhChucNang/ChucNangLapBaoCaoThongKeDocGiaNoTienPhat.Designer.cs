namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat
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
            this.pnWrapperBaoCao = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.dgvBaoCaoDocGiaNoTienPhat = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtNgayLapBaoCao = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnWrapperBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDocGiaNoTienPhat)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWrapperBaoCao
            // 
            this.pnWrapperBaoCao.Controls.Add(this.btnThoat);
            this.pnWrapperBaoCao.Controls.Add(this.btnHoanTat);
            this.pnWrapperBaoCao.Controls.Add(this.dgvBaoCaoDocGiaNoTienPhat);
            this.pnWrapperBaoCao.Controls.Add(this.label3);
            this.pnWrapperBaoCao.Controls.Add(this.btnLamMoi);
            this.pnWrapperBaoCao.Controls.Add(this.dtNgayLapBaoCao);
            this.pnWrapperBaoCao.Controls.Add(this.panel2);
            this.pnWrapperBaoCao.Location = new System.Drawing.Point(0, 0);
            this.pnWrapperBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.pnWrapperBaoCao.Name = "pnWrapperBaoCao";
            this.pnWrapperBaoCao.Size = new System.Drawing.Size(907, 652);
            this.pnWrapperBaoCao.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(635, 583);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 66);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Location = new System.Drawing.Point(403, 583);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(115, 66);
            this.btnHoanTat.TabIndex = 54;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // dgvBaoCaoDocGiaNoTienPhat
            // 
            this.dgvBaoCaoDocGiaNoTienPhat.AllowUserToResizeColumns = false;
            this.dgvBaoCaoDocGiaNoTienPhat.AllowUserToResizeRows = false;
            this.dgvBaoCaoDocGiaNoTienPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoDocGiaNoTienPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBaoCaoDocGiaNoTienPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoDocGiaNoTienPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDocGia,
            this.TienNo});
            this.dgvBaoCaoDocGiaNoTienPhat.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBaoCaoDocGiaNoTienPhat.Location = new System.Drawing.Point(27, 174);
            this.dgvBaoCaoDocGiaNoTienPhat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoCaoDocGiaNoTienPhat.MultiSelect = false;
            this.dgvBaoCaoDocGiaNoTienPhat.Name = "dgvBaoCaoDocGiaNoTienPhat";
            this.dgvBaoCaoDocGiaNoTienPhat.RowHeadersVisible = false;
            this.dgvBaoCaoDocGiaNoTienPhat.RowHeadersWidth = 51;
            this.dgvBaoCaoDocGiaNoTienPhat.Size = new System.Drawing.Size(853, 401);
            this.dgvBaoCaoDocGiaNoTienPhat.TabIndex = 53;
            // 
            // STT
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.STT.DefaultCellStyle = dataGridViewCellStyle6;
            this.STT.FillWeight = 50.76143F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "HoTenDG";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TenDocGia.DefaultCellStyle = dataGridViewCellStyle7;
            this.TenDocGia.FillWeight = 112.3096F;
            this.TenDocGia.HeaderText = "Tên đọc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "ConLai";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TienNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.TienNo.FillWeight = 112.3096F;
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.MinimumWidth = 6;
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ngày lập báo cáo:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(175, 583);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 66);
            this.btnLamMoi.TabIndex = 51;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtNgayLapBaoCao
            // 
            this.dtNgayLapBaoCao.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapBaoCao.Location = new System.Drawing.Point(421, 98);
            this.dtNgayLapBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLapBaoCao.Name = "dtNgayLapBaoCao";
            this.dtNgayLapBaoCao.Size = new System.Drawing.Size(265, 38);
            this.dtNgayLapBaoCao.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 74);
            this.panel2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "LẬP BÁO CÁO THỐNG KÊ ĐỘC GIẢ NỢ TIỀN PHẠT";
            // 
            // ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnWrapperBaoCao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat";
            this.Size = new System.Drawing.Size(907, 652);
            this.Load += new System.EventHandler(this.ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat_Load);
            this.SizeChanged += new System.EventHandler(this.ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat_SizeChanged);
            this.pnWrapperBaoCao.ResumeLayout(false);
            this.pnWrapperBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDocGiaNoTienPhat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWrapperBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.DataGridView dgvBaoCaoDocGiaNoTienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DateTimePicker dtNgayLapBaoCao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
