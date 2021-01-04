namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangCapNhatBangQuyDinh
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            this.TuoiToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTriThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachMuonToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayMuonToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhatTraTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(275, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "CẬP NHẬT QUY ĐỊNH";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(494, 450);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(221, 66);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(144, 450);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(221, 66);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.AllowUserToAddRows = false;
            this.dgvQuyDinh.AllowUserToDeleteRows = false;
            this.dgvQuyDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TuoiToiThieu,
            this.TuoiToiDa,
            this.GiaTriThe,
            this.SoNamXB,
            this.SoSachMuonToiDa,
            this.SoNgayMuonToiDa,
            this.TienPhatTraTre});
            this.dgvQuyDinh.Location = new System.Drawing.Point(3, 234);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.RowHeadersWidth = 51;
            this.dgvQuyDinh.RowTemplate.Height = 24;
            this.dgvQuyDinh.Size = new System.Drawing.Size(901, 150);
            this.dgvQuyDinh.TabIndex = 4;
            // 
            // TuoiToiThieu
            // 
            this.TuoiToiThieu.DataPropertyName = "TuoiToiThieu";
            this.TuoiToiThieu.HeaderText = "Tuổi Tối Thiểu";
            this.TuoiToiThieu.MinimumWidth = 6;
            this.TuoiToiThieu.Name = "TuoiToiThieu";
            // 
            // TuoiToiDa
            // 
            this.TuoiToiDa.DataPropertyName = "TuoiToiDa";
            this.TuoiToiDa.HeaderText = "Tuổi tối đa";
            this.TuoiToiDa.MinimumWidth = 6;
            this.TuoiToiDa.Name = "TuoiToiDa";
            // 
            // GiaTriThe
            // 
            this.GiaTriThe.DataPropertyName = "GiaTriThe";
            this.GiaTriThe.HeaderText = "Thời Hạn Thẻ Độc Giả";
            this.GiaTriThe.MinimumWidth = 6;
            this.GiaTriThe.Name = "GiaTriThe";
            // 
            // SoNamXB
            // 
            this.SoNamXB.DataPropertyName = "SoNamXB";
            this.SoNamXB.HeaderText = "Số Năm Xuất Bản";
            this.SoNamXB.MinimumWidth = 6;
            this.SoNamXB.Name = "SoNamXB";
            // 
            // SoSachMuonToiDa
            // 
            this.SoSachMuonToiDa.DataPropertyName = "SoSachMuonToiDa";
            this.SoSachMuonToiDa.HeaderText = "Số Sách Mượn Tối Đa";
            this.SoSachMuonToiDa.MinimumWidth = 6;
            this.SoSachMuonToiDa.Name = "SoSachMuonToiDa";
            // 
            // SoNgayMuonToiDa
            // 
            this.SoNgayMuonToiDa.DataPropertyName = "SoNgayMuonToiDa";
            this.SoNgayMuonToiDa.HeaderText = "Số Ngày Mượn Tối Đa";
            this.SoNgayMuonToiDa.MinimumWidth = 6;
            this.SoNgayMuonToiDa.Name = "SoNgayMuonToiDa";
            // 
            // TienPhatTraTre
            // 
            this.TienPhatTraTre.DataPropertyName = "TienPhatTraTre";
            this.TienPhatTraTre.HeaderText = "Tiền Phạt Trả Trễ";
            this.TienPhatTraTre.MinimumWidth = 6;
            this.TienPhatTraTre.Name = "TienPhatTraTre";
            // 
            // ManHinhChucNangCapNhatBangQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvQuyDinh);
            this.Name = "ManHinhChucNangCapNhatBangQuyDinh";
            this.Size = new System.Drawing.Size(907, 652);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvQuyDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuoiToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTriThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSachMuonToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayMuonToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhatTraTre;
    }
}
