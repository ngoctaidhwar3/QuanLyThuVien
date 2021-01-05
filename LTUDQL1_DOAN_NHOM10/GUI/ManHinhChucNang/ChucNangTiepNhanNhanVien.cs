using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangTiepNhanNhanVien : UserControl
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangTiepNhanNhanVien(HamChuyenTrang ChuyenTrangChu)
        {

            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }
        private void Tai_Thong_Tin()
        {
            
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "MMMM dd yyyy";
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayTiepNhan.CustomFormat = "MMMM dd yyyy";

           
            BangCapBUS bangCapBUS = new BangCapBUS();
            DataTable dsBangCap = bangCapBUS.LayDanhSachBangCap();
            cbbBangCap.DataSource = dsBangCap;
            cbbBangCap.DisplayMember = dsBangCap.Columns[1].ColumnName;
            cbbBangCap.ValueMember = dsBangCap.Columns[0].ColumnName;

            
            BoPhanBUS boPhanBUS = new BoPhanBUS();
            DataTable dsBoPhan = boPhanBUS.LayDanhSachBoPhan();
            cbbBoPhan.DataSource = dsBoPhan;
            cbbBoPhan.DisplayMember = dsBoPhan.Columns[1].ColumnName;
            cbbBoPhan.ValueMember = dsBoPhan.Columns[0].ColumnName;

            
            ChucVuBUS chucVuBUS = new ChucVuBUS();
            DataTable dsChucVu = chucVuBUS.LayDanhSachChucVu();
            cbbChucVu.DataSource = dsChucVu;
            cbbChucVu.DisplayMember = dsChucVu.Columns[1].ColumnName;
            cbbChucVu.ValueMember = dsChucVu.Columns[0].ColumnName;

            
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            txtMaNhanVien.Text = nhanVienBUS.LayMaNhanVienMoi();
        }

        private void LamMoi()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void ManHinhChucNangTiepNhanNhanVien_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            try
            {
                nhanVien.MaNhanVien = txtMaNhanVien.Text;
                nhanVien.HoTenNV = txtHoTen.Text;
                nhanVien.NgaySinh = dtpNgaySinh.Value.ToString("MM/dd/yyyy").Substring(0, 10);
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.DienThoai = txtDienThoai.Text;
                nhanVien.MaTTNV = "TTNV01";
                nhanVien.BangCap = cbbBangCap.SelectedValue.ToString();
                nhanVien.BoPhan = cbbBoPhan.SelectedValue.ToString();
                nhanVien.ChucVu = cbbChucVu.SelectedValue.ToString();

                NhanVienBUS nhanVienBUS = new NhanVienBUS();
                nhanVienBUS.ThemNhanVien(nhanVien);
                MessageBox.Show("Thêm thành công");

                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại. Lỗi:" + ex.ToString());
            }
        }

        private void btnChupHinh_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Chức năng đang trong giai đoạn bảo trì");
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Chức năng đang trong giai đoạn bảo trì");
        }
    }
}
