namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangLapBaoCaoThongKeSachTraTre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnWrapperBaoCao = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.dgvBaoCaoSachTraTre = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayTraTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayLapBaoCao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnWrapperBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSachTraTre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnWrapperBaoCao
            // 
            this.pnWrapperBaoCao.Controls.Add(this.btnThoat);
            this.pnWrapperBaoCao.Controls.Add(this.btnHoanTat);
            this.pnWrapperBaoCao.Controls.Add(this.dgvBaoCaoSachTraTre);
            this.pnWrapperBaoCao.Controls.Add(this.dtNgayLapBaoCao);
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
            this.btnThoat.TabIndex = 55;
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
            this.btnHoanTat.TabIndex = 54;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCaoSachTraTre
            // 
            this.dgvBaoCaoSachTraTre.AllowUserToResizeColumns = false;
            this.dgvBaoCaoSachTraTre.AllowUserToResizeRows = false;
            this.dgvBaoCaoSachTraTre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoSachTraTre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBaoCaoSachTraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoSachTraTre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSach,
            this.NgayMuon,
            this.SoNgayTraTre});
            this.dgvBaoCaoSachTraTre.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBaoCaoSachTraTre.Location = new System.Drawing.Point(27, 162);
            this.dgvBaoCaoSachTraTre.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoCaoSachTraTre.MultiSelect = false;
            this.dgvBaoCaoSachTraTre.Name = "dgvBaoCaoSachTraTre";
            this.dgvBaoCaoSachTraTre.RowHeadersVisible = false;
            this.dgvBaoCaoSachTraTre.RowHeadersWidth = 51;
            this.dgvBaoCaoSachTraTre.Size = new System.Drawing.Size(853, 422);
            this.dgvBaoCaoSachTraTre.TabIndex = 53;
            // 
            // STT
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.STT.DefaultCellStyle = dataGridViewCellStyle7;
            this.STT.FillWeight = 50.76143F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TenSach.DefaultCellStyle = dataGridViewCellStyle8;
            this.TenSach.FillWeight = 112.3096F;
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NgayMuon.DefaultCellStyle = dataGridViewCellStyle9;
            this.NgayMuon.FillWeight = 112.3096F;
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // SoNgayTraTre
            // 
            this.SoNgayTraTre.DataPropertyName = "SoNgayTraTre";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SoNgayTraTre.DefaultCellStyle = dataGridViewCellStyle10;
            this.SoNgayTraTre.FillWeight = 112.3096F;
            this.SoNgayTraTre.HeaderText = "Số ngày trả trễ";
            this.SoNgayTraTre.MinimumWidth = 6;
            this.SoNgayTraTre.Name = "SoNgayTraTre";
            this.SoNgayTraTre.ReadOnly = true;
            // 
            // dtNgayLapBaoCao
            // 
            this.dtNgayLapBaoCao.CustomFormat = "dd-MM-yyyy";
            this.dtNgayLapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapBaoCao.Location = new System.Drawing.Point(433, 87);
            this.dtNgayLapBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLapBaoCao.Name = "dtNgayLapBaoCao";
            this.dtNgayLapBaoCao.Size = new System.Drawing.Size(265, 38);
            this.dtNgayLapBaoCao.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ngày lập báo cáo:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(175, 592);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 46);
            this.btnLamMoi.TabIndex = 51;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "LẬP BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ";
            // 
            // ManHinhChucNangLapBaoCaoThongKeSachTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnWrapperBaoCao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManHinhChucNangLapBaoCaoThongKeSachTraTre";
            this.Size = new System.Drawing.Size(907, 652);
            this.pnWrapperBaoCao.ResumeLayout(false);
            this.pnWrapperBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSachTraTre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnWrapperBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.DataGridView dgvBaoCaoSachTraTre;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayTraTre;
        private System.Windows.Forms.DateTimePicker dtNgayLapBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
    }
}
