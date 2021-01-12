using GUI.DangNhap;
using System;
using GUI.ManHinhChucNang;
using GUI.MenuChucNang;
using System.Windows.Forms;
namespace GUI
{
    public partial class MenuForm : Form
    {
        public delegate void HamChuyenTrang(int So);
        public MenuForm()
        {
            InitializeComponent();

            pnChucNang.Controls.Add(new MenuChucNangSach(ChuyenManHinhChucNang));
            pnContent.Controls.Add(new MainForm(ChuyenManHinhChucNang));
            pnRight.Controls.Add(new ManHinhDangNhap());
        }

        private void ChuyenManHinhChucNang(int ChucNang)
        {
            pnContent.Controls.Clear();

            switch (ChucNang)
            {
                case 0:
                    pnContent.Controls.Add(new MainForm(ChuyenManHinhChucNang));
                    break;
                case 1:
                    pnContent.Controls.Add(new ManHinhChucNangTiepNhanNhanVien(ChuyenManHinhChucNang));
                    break;
                case 2:
                    pnContent.Controls.Add(new ManHinhChucNangLapTheDocGia(ChuyenManHinhChucNang));
                    break;
                case 3:
                    pnContent.Controls.Add(new ManHinhChucNangTiepNhanSachMoi(ChuyenManHinhChucNang));
                    break;
                case 4:
                    pnContent.Controls.Add(new ManHinhChucNangTraCuuSach(ChuyenManHinhChucNang));
                    break;
                case 5:
                    pnContent.Controls.Add(new ManHinhChucNangChoMuonSach(ChuyenManHinhChucNang));
                    break;
                case 6:
                    pnContent.Controls.Add(new ManHinhChucNangNhanTraSach(ChuyenManHinhChucNang));
                    break;
                case 7:
                    pnContent.Controls.Add(new ManHinhChucNangLapPhieuThuTienPhat(ChuyenManHinhChucNang));
                    break;
                case 8:
                    pnContent.Controls.Add(new ManHinhChucNangGhiNhanMatSach(ChuyenManHinhChucNang));
                    break;
                case 9:
                    pnContent.Controls.Add(new ManHinhChucNangThanhLySach(ChuyenManHinhChucNang));
                    break;
                case 10:
                    pnContent.Controls.Add(new ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai(ChuyenManHinhChucNang));
                    break;
                case 11:
                    pnContent.Controls.Add(new ManHinhChucNangLapBaoCaoThongKeSachTraTre(ChuyenManHinhChucNang));
                    break;
                case 12:
                    pnContent.Controls.Add(new ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat(ChuyenManHinhChucNang));
                    break;
                case 13:
                    pnContent.Controls.Add(new ManHinhChucNangQuanLyNhanVien(ChuyenManHinhChucNang));
                    break;
                case 14:
                    pnContent.Controls.Add(new ManHinhChucNangQuanLyDocGia(ChuyenManHinhChucNang));
                    break;
                case 15:
                    pnContent.Controls.Add(new ManHinhChucNangCapNhatBangQuyDinh());
                    break;
                case 16:
                    pnContent.Controls.Add(new ManHinhChucNangCapNhatThongTinNhanVien());
                    break;
                case 17:
                    pnContent.Controls.Add(new ManHinhChucNangCapNhatBangLienQuanDocGia());
                    break;
                case 18:
                    pnContent.Controls.Add(new ManHinhChucNangCapNhatBangLienQuanSach());
                    break;
                case 19:
                    pnContent.Controls.Add(new ManHinhChucNangCapNhatBangLyDoThanhLy());
                    break;
                default:
                    break;
            }
        }

               

        private void ChuyenTrang(int SoTrang)
        {
            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangQuyDinh1(ChuyenTrang, ChuyenManHinhChucNang));
        }

        

        

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new MainForm(ChuyenManHinhChucNang));
        }

        private void btnItemLuuTru_Click(object sender, EventArgs e)
        {

            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangLuuTru());
        }

        private void btnItemImportExport_Click(object sender, EventArgs e)
        {
            
            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangExportImport());
        }

        private void btnItemThuVien_Click(object sender, EventArgs e)
        {

            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangThuVien(ChuyenManHinhChucNang));
        }

        private void btnItemDocGia_Click(object sender, EventArgs e)
        {

            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangDocGia(ChuyenManHinhChucNang));
        }

        private void btnItemSach_Click(object sender, EventArgs e)
        {

            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangSach(ChuyenManHinhChucNang));
        }

        private void btnItemQuyDinh_Click(object sender, EventArgs e)
        {

            pnChucNang.Controls.Clear();
            pnChucNang.Controls.Add(new MenuChucNangQuyDinh1(ChuyenTrang, ChuyenManHinhChucNang));
        }

       
      
    }
}
