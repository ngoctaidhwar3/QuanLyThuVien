namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai
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
            this.pnWrapperBaoCao = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.dgvBaoCaoMuonSachTheoTheLoai = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtThanglapBaoCao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnWrapperBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoMuonSachTheoTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // pnWrapperBaoCao
            // 
            this.pnWrapperBaoCao.Controls.Add(this.btnThoat);
            this.pnWrapperBaoCao.Controls.Add(this.btnHoanTat);
            this.pnWrapperBaoCao.Controls.Add(this.dgvBaoCaoMuonSachTheoTheLoai);
            this.pnWrapperBaoCao.Controls.Add(this.dtThanglapBaoCao);
            this.pnWrapperBaoCao.Controls.Add(this.label3);
            this.pnWrapperBaoCao.Controls.Add(this.btnLamMoi);
            this.pnWrapperBaoCao.Controls.Add(this.label1);
            this.pnWrapperBaoCao.Location = new System.Drawing.Point(0, 0);
            this.pnWrapperBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.pnWrapperBaoCao.Name = "pnWrapperBaoCao";
            this.pnWrapperBaoCao.Size = new System.Drawing.Size(907, 652);
            this.pnWrapperBaoCao.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(635, 592);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 48;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Location = new System.Drawing.Point(403, 592);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(100, 46);
            this.btnHoanTat.TabIndex = 47;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCaoMuonSachTheoTheLoai
            // 
            this.dgvBaoCaoMuonSachTheoTheLoai.AllowUserToResizeColumns = false;
            this.dgvBaoCaoMuonSachTheoTheLoai.AllowUserToResizeRows = false;
            this.dgvBaoCaoMuonSachTheoTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoMuonSachTheoTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCaoMuonSachTheoTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoMuonSachTheoTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTheLoai,
            this.SoLuotMuon,
            this.TiLe});
            this.dgvBaoCaoMuonSachTheoTheLoai.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBaoCaoMuonSachTheoTheLoai.Location = new System.Drawing.Point(27, 162);
            this.dgvBaoCaoMuonSachTheoTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoCaoMuonSachTheoTheLoai.MultiSelect = false;
            this.dgvBaoCaoMuonSachTheoTheLoai.Name = "dgvBaoCaoMuonSachTheoTheLoai";
            this.dgvBaoCaoMuonSachTheoTheLoai.RowHeadersVisible = false;
            this.dgvBaoCaoMuonSachTheoTheLoai.RowHeadersWidth = 51;
            this.dgvBaoCaoMuonSachTheoTheLoai.Size = new System.Drawing.Size(853, 422);
            this.dgvBaoCaoMuonSachTheoTheLoai.TabIndex = 46;
            // 
            // STT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.FillWeight = 50.76143F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TenTheLoai.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenTheLoai.FillWeight = 112.3096F;
            this.TenTheLoai.HeaderText = "Tên thể loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // SoLuotMuon
            // 
            this.SoLuotMuon.DataPropertyName = "SoLuotMuon";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SoLuotMuon.DefaultCellStyle = dataGridViewCellStyle4;
            this.SoLuotMuon.FillWeight = 112.3096F;
            this.SoLuotMuon.HeaderText = "Số lượt mượn";
            this.SoLuotMuon.MinimumWidth = 6;
            this.SoLuotMuon.Name = "SoLuotMuon";
            this.SoLuotMuon.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.DataPropertyName = "TiLe";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TiLe.DefaultCellStyle = dataGridViewCellStyle5;
            this.TiLe.FillWeight = 112.3096F;
            this.TiLe.HeaderText = "Tỉ lệ";
            this.TiLe.MinimumWidth = 6;
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            // 
            // dtThanglapBaoCao
            // 
            this.dtThanglapBaoCao.CustomFormat = "MM-yyyy";
            this.dtThanglapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThanglapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThanglapBaoCao.Location = new System.Drawing.Point(435, 87);
            this.dtThanglapBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.dtThanglapBaoCao.Name = "dtThanglapBaoCao";
            this.dtThanglapBaoCao.Size = new System.Drawing.Size(265, 38);
            this.dtThanglapBaoCao.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tháng lập báo cáo:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(175, 592);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 46);
            this.btnLamMoi.TabIndex = 44;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "LẬP BÁO CÁO THỐNG KÊ MƯỢN SÁCH THEO THỂ LOẠI";
            // 
            // ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnWrapperBaoCao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai";
            this.Size = new System.Drawing.Size(907, 652);
            this.pnWrapperBaoCao.ResumeLayout(false);
            this.pnWrapperBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoMuonSachTheoTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWrapperBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.DataGridView dgvBaoCaoMuonSachTheoTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.DateTimePicker dtThanglapBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
    }
}
