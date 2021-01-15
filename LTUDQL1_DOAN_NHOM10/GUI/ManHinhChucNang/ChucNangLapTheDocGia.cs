using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using BUS.DocGiaBUS;
using DTO;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangLapTheDocGia : UserControl
    {
        DocGiaDTO docGia = new DocGiaDTO();
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangLapTheDocGia(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }
        private void Tai_Thong_Tin() 
        {
           
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd MMMM yyyy";
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayTiepNhan.CustomFormat = "dd MMMM yyyy";


            
            LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();
            DataTable dsLoaiDocGia = loaiDocGiaBUS.LayDanhSachLoaiDocGia();
            cbbLoaiDocGia.DataSource = dsLoaiDocGia;
            cbbLoaiDocGia.DisplayMember = dsLoaiDocGia.Columns[1].ColumnName;
            cbbLoaiDocGia.ValueMember = dsLoaiDocGia.Columns[0].ColumnName;


            
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            DataTable dsNhanVien = nhanVienBUS.LayDanhSachNhanVienTheoBoPhan("BP02");
            cbbMaNhanVien.DataSource = dsNhanVien;
            cbbMaNhanVien.DisplayMember = dsNhanVien.Columns[1].ColumnName;
            cbbMaNhanVien.ValueMember = dsNhanVien.Columns[0].ColumnName;

         
            DocGiaBUS docGiaBUS = new DocGiaBUS();
            txtMaDocGia.Text = docGiaBUS.LayMaDocGiaMoi();

        }

        private void LamMoi()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Text = "";
            txtDiaChi.Text = "";
        }
        private void ManHinhChucNangLapTheDocGia_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            try
            {
                docGia.MaDocGia = txtMaDocGia.Text;
                docGia.HoTenDG = txtHoTen.Text;
                docGia.NgaySinh = dtpNgaySinh.Value.ToString("MM/dd/yyyy").Substring(0, 10);
                docGia.DiaChi = txtDiaChi.Text;
                docGia.Email = txtEmail.Text;
                docGia.TTDG = "TTDG01";
                docGia.MaLoaiDG = cbbLoaiDocGia.SelectedValue.ToString();
                docGia.NvLapThe = cbbMaNhanVien.SelectedValue.ToString();
                docGia.NgayLapThe = dtpNgayTiepNhan.Value.ToString("MM/dd/yyyy").Substring(0, 10);
                docGia.TongNo = 0;
                QuyDinhBUS quyDinhBUS = new QuyDinhBUS();
                DataTable dsQuyDinh = quyDinhBUS.LayDanhSachQuyDinh();
                int thoiHanThe = int.Parse(dsQuyDinh.Rows[0][2].ToString());
                docGia.NgayHetHan = dtpNgayTiepNhan.Value.AddMonths(thoiHanThe).ToString("MM/dd/yyyy").Substring(0, 10);

                DocGiaBUS docGiaBUS = new DocGiaBUS();
                docGiaBUS.ThemDocGia(docGia);
                MessageBox.Show("Thêm thành công");

                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại. Lỗi:" + ex.ToString());
            }
        }

  

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }
    }
}
