﻿using BUS;
using System;
using System.Data;
using System.Windows.Forms;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangTraCuuSach : UserControl
    {
        SachBUS bUS = new SachBUS();
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangTraCuuSach(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private void ManHinhChucNangTraCuuSach_Load(object sender, EventArgs e)
        {
           
            DataTable dataTable = bUS.GetDatasByCommand("SELECT MaTheLoai, TenTheLoai FROM TheLoaiSach");
            cbCategory.DataSource = dataTable;
            cbCategory.DisplayMember = "TenTheLoai";
            cbCategory.ValueMember = "MaTheLoai";

           
            dataTable = bUS.GetDatasByCommand("SELECT MaTacGia, TenTacGia FROM TACGIA");
            cbAuthor.DataSource = dataTable;
            cbAuthor.DisplayMember = "TenTacGia";
            cbAuthor.ValueMember = "MaTacGia";

            
            dataTable = bUS.GetDatasByCommand("SELECT MaNXB, TenNXB FROM NHAXUATBAN");
            cbPublisher.DataSource = dataTable;
            cbPublisher.DisplayMember = "TenNXB";
            cbPublisher.ValueMember = "MaNXB";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DTO.SachDTO book = new DTO.SachDTO
            {
                Ten = txtName.Text == String.Empty ? String.Empty : txtName.Text,
                MaTheLoai = cbCategory.SelectedValue.ToString(),
                MaTacGia = cbAuthor.SelectedValue.ToString(),
                MaMXB = cbPublisher.SelectedValue.ToString(),
            };

            dgvBook.DataSource =bUS.FindBook(book);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }
    }
}
