namespace GUI.MenuChucNang
{
    partial class MenuChucNangDocGia
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
            this.pnChucNangDocGia = new System.Windows.Forms.Panel();
            this.btnItemQuanLyDocGia = new System.Windows.Forms.Button();
            this.btnItemLapPhieuThuTienPhat = new System.Windows.Forms.Button();
            this.btnItemLapTheDocGia = new System.Windows.Forms.Button();
            this.timerAnimationSlide = new System.Windows.Forms.Timer(this.components);
            this.pnChucNangDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChucNangDocGia
            // 
            this.pnChucNangDocGia.BackColor = System.Drawing.Color.White;
            this.pnChucNangDocGia.Controls.Add(this.btnItemQuanLyDocGia);
            this.pnChucNangDocGia.Controls.Add(this.btnItemLapPhieuThuTienPhat);
            this.pnChucNangDocGia.Controls.Add(this.btnItemLapTheDocGia);
            this.pnChucNangDocGia.Location = new System.Drawing.Point(0, 0);
            this.pnChucNangDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnChucNangDocGia.Name = "pnChucNangDocGia";
            this.pnChucNangDocGia.Size = new System.Drawing.Size(247, 578);
            this.pnChucNangDocGia.TabIndex = 0;
            // 
            // btnItemQuanLyDocGia
            // 
            this.btnItemQuanLyDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemQuanLyDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemQuanLyDocGia.Location = new System.Drawing.Point(0, 134);
            this.btnItemQuanLyDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemQuanLyDocGia.Name = "btnItemQuanLyDocGia";
            this.btnItemQuanLyDocGia.Size = new System.Drawing.Size(247, 74);
            this.btnItemQuanLyDocGia.TabIndex = 26;
            this.btnItemQuanLyDocGia.Text = "Quản Lý Độc Giả";
            this.btnItemQuanLyDocGia.UseVisualStyleBackColor = true;
            this.btnItemQuanLyDocGia.Click += new System.EventHandler(this.btnItemQuanLyDocGia_Click);
            // 
            // btnItemLapPhieuThuTienPhat
            // 
            this.btnItemLapPhieuThuTienPhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemLapPhieuThuTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemLapPhieuThuTienPhat.Location = new System.Drawing.Point(0, 60);
            this.btnItemLapPhieuThuTienPhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemLapPhieuThuTienPhat.Name = "btnItemLapPhieuThuTienPhat";
            this.btnItemLapPhieuThuTienPhat.Size = new System.Drawing.Size(247, 74);
            this.btnItemLapPhieuThuTienPhat.TabIndex = 28;
            this.btnItemLapPhieuThuTienPhat.Text = "Lập Phiếu Thu Tiền Phạt";
            this.btnItemLapPhieuThuTienPhat.UseVisualStyleBackColor = true;
            this.btnItemLapPhieuThuTienPhat.Click += new System.EventHandler(this.btnItemLapPhieuThuTienPhat_Click);
            // 
            // btnItemLapTheDocGia
            // 
            this.btnItemLapTheDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemLapTheDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemLapTheDocGia.Location = new System.Drawing.Point(0, 0);
            this.btnItemLapTheDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemLapTheDocGia.Name = "btnItemLapTheDocGia";
            this.btnItemLapTheDocGia.Size = new System.Drawing.Size(247, 60);
            this.btnItemLapTheDocGia.TabIndex = 27;
            this.btnItemLapTheDocGia.Text = "Lập Thẻ Độc Giả";
            this.btnItemLapTheDocGia.UseVisualStyleBackColor = true;
            this.btnItemLapTheDocGia.Click += new System.EventHandler(this.btnItemLapTheDocGia_Click);
            // 
            // timerAnimationSlide
            // 
            this.timerAnimationSlide.Interval = 1;
            this.timerAnimationSlide.Tick += new System.EventHandler(this.timerAnimationSlide_Tick);
            // 
            // MenuChucNangDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnChucNangDocGia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuChucNangDocGia";
            this.Size = new System.Drawing.Size(247, 578);
            this.Load += new System.EventHandler(this.MenuChucNangDocGia_Load);
            this.pnChucNangDocGia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnChucNangDocGia;
        private System.Windows.Forms.Button btnItemQuanLyDocGia;
        private System.Windows.Forms.Button btnItemLapPhieuThuTienPhat;
        private System.Windows.Forms.Button btnItemLapTheDocGia;
        private System.Windows.Forms.Timer timerAnimationSlide;
    }
}
