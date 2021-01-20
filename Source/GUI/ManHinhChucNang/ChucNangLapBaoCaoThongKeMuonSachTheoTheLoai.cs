using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using BUS;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai : UserControl
    {
        HamChuyenTrang ChuyenTrangChu;

        public ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();

            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvBaoCaoMuonSachTheoTheLoai.Rows.Count; i++)
            {
                dgvBaoCaoMuonSachTheoTheLoai[0, i].Value = i + 1;
            }
        }


        private void ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }

        private void ManHinhChucNangLapBaoCaoThongKeMuonSachTheoTheLoai_SizeChanged(object sender, EventArgs e)
        {
            pnWrapperBaoCao.Location = new Point(this.Width / 2 - pnWrapperBaoCao.Width / 2, pnWrapperBaoCao.Location.Y);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtThanglapBaoCao.Value = DateTime.Now;

            QuanLyBaoCaoBUS quanLyBaoCaoBUS = new QuanLyBaoCaoBUS();
            DataTable dtThongTinBaoCao = quanLyBaoCaoBUS.LayThongTinBaoCaoMuonSachTheoTheLoai("0001-01-01");

            dgvBaoCaoMuonSachTheoTheLoai.DataSource = dtThongTinBaoCao;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                string ThangLapBaoCao = dtThanglapBaoCao.Value.ToString("yyyy-MM-dd");

                QuanLyBaoCaoBUS quanLyBaoCaoBUS = new QuanLyBaoCaoBUS();
                DataTable dtThongTinBaoCao = quanLyBaoCaoBUS.LayThongTinBaoCaoMuonSachTheoTheLoai(ThangLapBaoCao);


                dgvBaoCaoMuonSachTheoTheLoai.DataSource = dtThongTinBaoCao;
                CapNhatSTT();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }
    }
}
