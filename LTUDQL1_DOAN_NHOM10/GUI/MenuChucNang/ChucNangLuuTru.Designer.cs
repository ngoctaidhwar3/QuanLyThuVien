namespace GUI.MenuChucNang
{
    partial class MenuChucNangLuuTru
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
            this.components = new System.ComponentModel.Container();
            this.pnChucNangLuuTru = new System.Windows.Forms.Panel();
            this.btnItemQuanLyDuLieuTamXoa = new System.Windows.Forms.Button();
            this.btnItemPhucHoiDuLieu = new System.Windows.Forms.Button();
            this.btnItemSaoLuuDuLieu = new System.Windows.Forms.Button();
            this.timerAnimationSlide = new System.Windows.Forms.Timer(this.components);
            this.pnChucNangLuuTru.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChucNangLuuTru
            // 
            this.pnChucNangLuuTru.Controls.Add(this.btnItemQuanLyDuLieuTamXoa);
            this.pnChucNangLuuTru.Controls.Add(this.btnItemPhucHoiDuLieu);
            this.pnChucNangLuuTru.Controls.Add(this.btnItemSaoLuuDuLieu);
            this.pnChucNangLuuTru.Location = new System.Drawing.Point(0, 0);
            this.pnChucNangLuuTru.Margin = new System.Windows.Forms.Padding(4);
            this.pnChucNangLuuTru.Name = "pnChucNangLuuTru";
            this.pnChucNangLuuTru.Size = new System.Drawing.Size(247, 578);
            this.pnChucNangLuuTru.TabIndex = 0;
            // 
            // btnItemQuanLyDuLieuTamXoa
            // 
            this.btnItemQuanLyDuLieuTamXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemQuanLyDuLieuTamXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemQuanLyDuLieuTamXoa.Location = new System.Drawing.Point(0, 148);
            this.btnItemQuanLyDuLieuTamXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemQuanLyDuLieuTamXoa.Name = "btnItemQuanLyDuLieuTamXoa";
            this.btnItemQuanLyDuLieuTamXoa.Size = new System.Drawing.Size(247, 74);
            this.btnItemQuanLyDuLieuTamXoa.TabIndex = 14;
            this.btnItemQuanLyDuLieuTamXoa.Text = "Dữ Liệu Xóa Tạm";
            this.btnItemQuanLyDuLieuTamXoa.UseVisualStyleBackColor = true;
            // 
            // btnItemPhucHoiDuLieu
            // 
            this.btnItemPhucHoiDuLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemPhucHoiDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemPhucHoiDuLieu.Location = new System.Drawing.Point(0, 74);
            this.btnItemPhucHoiDuLieu.Name = "btnItemPhucHoiDuLieu";
            this.btnItemPhucHoiDuLieu.Size = new System.Drawing.Size(247, 74);
            this.btnItemPhucHoiDuLieu.TabIndex = 13;
            this.btnItemPhucHoiDuLieu.Text = "Phục Hồi Dữ Liệu";
            this.btnItemPhucHoiDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnItemSaoLuuDuLieu
            // 
            this.btnItemSaoLuuDuLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemSaoLuuDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSaoLuuDuLieu.Location = new System.Drawing.Point(0, 0);
            this.btnItemSaoLuuDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemSaoLuuDuLieu.Name = "btnItemSaoLuuDuLieu";
            this.btnItemSaoLuuDuLieu.Size = new System.Drawing.Size(247, 74);
            this.btnItemSaoLuuDuLieu.TabIndex = 12;
            this.btnItemSaoLuuDuLieu.Text = "Sao Lưu Dữ Liệu";
            this.btnItemSaoLuuDuLieu.UseVisualStyleBackColor = true;
            // 
            // timerAnimationSlide
            // 
            this.timerAnimationSlide.Interval = 1;
            this.timerAnimationSlide.Tick += new System.EventHandler(this.timerAnimationSlide_Tick);
            // 
            // MenuChucNangLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnChucNangLuuTru);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuChucNangLuuTru";
            this.Size = new System.Drawing.Size(247, 578);
            this.Load += new System.EventHandler(this.MenuChucNangLuuTru_Load);
            this.pnChucNangLuuTru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChucNangLuuTru;
        private System.Windows.Forms.Button btnItemQuanLyDuLieuTamXoa;
        private System.Windows.Forms.Button btnItemPhucHoiDuLieu;
        private System.Windows.Forms.Button btnItemSaoLuuDuLieu;
        private System.Windows.Forms.Timer timerAnimationSlide;
    }
}
