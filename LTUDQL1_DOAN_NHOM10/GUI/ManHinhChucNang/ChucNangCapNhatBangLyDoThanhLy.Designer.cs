namespace GUI.ManHinhChucNang
{
    partial class ManHinhChucNangCapNhatBangLyDoThanhLy
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
            this.txtMaLyDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaLyDo = new System.Windows.Forms.Button();
            this.btnSuaLyDo = new System.Windows.Forms.Button();
            this.dgvLyDoThanhLySach = new System.Windows.Forms.DataGridView();
            this.MaLyDoThanhLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLyDo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLyDoThanhLySach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Mã Lý Do Thanh Lý";
            // 
            // txtMaLyDo
            // 
            this.txtMaLyDo.Enabled = false;
            this.txtMaLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLyDo.Location = new System.Drawing.Point(205, 478);
            this.txtMaLyDo.Name = "txtMaLyDo";
            this.txtMaLyDo.Size = new System.Drawing.Size(257, 30);
            this.txtMaLyDo.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(525, 478);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(369, 30);
            this.txtMoTa.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Lý Do Thanh Lý";
            // 
            // btnXoaLyDo
            // 
            this.btnXoaLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLyDo.Location = new System.Drawing.Point(732, 583);
            this.btnXoaLyDo.Name = "btnXoaLyDo";
            this.btnXoaLyDo.Size = new System.Drawing.Size(162, 43);
            this.btnXoaLyDo.TabIndex = 95;
            this.btnXoaLyDo.Text = "Xóa";
            this.btnXoaLyDo.UseVisualStyleBackColor = true;
            this.btnXoaLyDo.Click += new System.EventHandler(this.btnXoaLyDo_Click);
            // 
            // btnSuaLyDo
            // 
            this.btnSuaLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLyDo.Location = new System.Drawing.Point(392, 583);
            this.btnSuaLyDo.Name = "btnSuaLyDo";
            this.btnSuaLyDo.Size = new System.Drawing.Size(163, 43);
            this.btnSuaLyDo.TabIndex = 94;
            this.btnSuaLyDo.Text = "Sửa";
            this.btnSuaLyDo.UseVisualStyleBackColor = true;
            this.btnSuaLyDo.Click += new System.EventHandler(this.btnSuaLyDo_Click);
            // 
            // dgvLyDoThanhLySach
            // 
            this.dgvLyDoThanhLySach.AllowUserToAddRows = false;
            this.dgvLyDoThanhLySach.AllowUserToDeleteRows = false;
            this.dgvLyDoThanhLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLyDoThanhLySach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLyDoThanhLy,
            this.MoTa});
            this.dgvLyDoThanhLySach.Location = new System.Drawing.Point(4, 137);
            this.dgvLyDoThanhLySach.Name = "dgvLyDoThanhLySach";
            this.dgvLyDoThanhLySach.ReadOnly = true;
            this.dgvLyDoThanhLySach.RowHeadersVisible = false;
            this.dgvLyDoThanhLySach.RowHeadersWidth = 51;
            this.dgvLyDoThanhLySach.RowTemplate.Height = 24;
            this.dgvLyDoThanhLySach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLyDoThanhLySach.Size = new System.Drawing.Size(901, 248);
            this.dgvLyDoThanhLySach.TabIndex = 93;
            this.dgvLyDoThanhLySach.SelectionChanged += new System.EventHandler(this.dgvLyDoThanhLySach_SelectionChanged);
            // 
            // MaLyDoThanhLy
            // 
            this.MaLyDoThanhLy.DataPropertyName = "MaLyDoThanhLy";
            this.MaLyDoThanhLy.FillWeight = 193.5829F;
            this.MaLyDoThanhLy.HeaderText = "Mã Lý Do Thanh Lý Sách";
            this.MaLyDoThanhLy.MinimumWidth = 6;
            this.MaLyDoThanhLy.Name = "MaLyDoThanhLy";
            this.MaLyDoThanhLy.ReadOnly = true;
            this.MaLyDoThanhLy.Width = 300;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.FillWeight = 6.417114F;
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 600;
            // 
            // btnThemLyDo
            // 
            this.btnThemLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLyDo.Location = new System.Drawing.Point(19, 583);
            this.btnThemLyDo.Name = "btnThemLyDo";
            this.btnThemLyDo.Size = new System.Drawing.Size(174, 43);
            this.btnThemLyDo.TabIndex = 92;
            this.btnThemLyDo.Text = "Thêm";
            this.btnThemLyDo.UseVisualStyleBackColor = true;
            this.btnThemLyDo.Click += new System.EventHandler(this.btnThemLyDo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(143, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(564, 32);
            this.label13.TabIndex = 91;
            this.label13.Text = "CẬP NHẬT BẢNG LÝ DO THANH LÝ SÁCH";
            // 
            // ManHinhChucNangCapNhatBangLyDoThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLyDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaLyDo);
            this.Controls.Add(this.btnSuaLyDo);
            this.Controls.Add(this.dgvLyDoThanhLySach);
            this.Controls.Add(this.btnThemLyDo);
            this.Controls.Add(this.label13);
            this.Name = "ManHinhChucNangCapNhatBangLyDoThanhLy";
            this.Size = new System.Drawing.Size(907, 652);
            this.Load += new System.EventHandler(this.ManHinhChucNangCapNhatBangLyDoThanhLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLyDoThanhLySach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLyDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaLyDo;
        private System.Windows.Forms.Button btnSuaLyDo;
        private System.Windows.Forms.DataGridView dgvLyDoThanhLySach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLyDoThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.Button btnThemLyDo;
        private System.Windows.Forms.Label label13;
    }
}
