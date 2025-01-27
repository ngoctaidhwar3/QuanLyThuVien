﻿using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangCapNhatBangQuyDinh : UserControl
    {
        DataTable dsQuyDinh;
        public ManHinhChucNangCapNhatBangQuyDinh()
        {
            InitializeComponent();
        }
        private void Tai_Thong_Tin()
        {

            QuyDinhBUS QuyDinhBUS = new QuyDinhBUS();
            dsQuyDinh = QuyDinhBUS.LayDanhSachQuyDinh();

            dgvQuyDinh.DataSource = dsQuyDinh;
        }

        private void ManHinhChucNangCapNhatBangQuyDinh_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin();

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                dgvQuyDinh.Update();
                DataTable dataTableUpdate = new DataTable();
                dataTableUpdate = dsQuyDinh.GetChanges();
                if (dataTableUpdate != null)
                {
                    QuyDinhBUS QuyDinhBUS = new QuyDinhBUS();
                    QuyDinhBUS.CapNhatQuyDinh(dataTableUpdate);
                    Tai_Thong_Tin();
                }
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cập nhật thất bại - Lỗi: " + ex.ToString());
            }

        }
    }
}
