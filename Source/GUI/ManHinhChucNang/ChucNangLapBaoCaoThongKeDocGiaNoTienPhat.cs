using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using BUS;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat : UserControl
    {
        HamChuyenTrang ChuyenTrangChu;

        public ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();

            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvBaoCaoDocGiaNoTienPhat.Rows.Count; i++)
            {
                dgvBaoCaoDocGiaNoTienPhat[0, i].Value = i + 1;
            }
        }

        private void ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }

        private void ManHinhChucNangLapBaoCaoThongKeDocGiaNoTienPhat_SizeChanged(object sender, EventArgs e)
        {
            pnWrapperBaoCao.Location = new Point(this.Width / 2 - pnWrapperBaoCao.Width / 2, pnWrapperBaoCao.Location.Y);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtNgayLapBaoCao.Value = DateTime.Now;

            QuanLyBaoCaoBUS quanLyBaoCaoBUS = new QuanLyBaoCaoBUS();
            DataTable dtThongTinBaoCao = quanLyBaoCaoBUS.LayThongTinBaoCaoDocGiaNoTienPhat("0001-01-01");

            dgvBaoCaoDocGiaNoTienPhat.DataSource = dtThongTinBaoCao;

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                string NgayLapBaoCao = dtNgayLapBaoCao.Value.ToString("yyyy-MM-dd");

                QuanLyBaoCaoBUS quanLyBaoCaoBUS = new QuanLyBaoCaoBUS();
                DataTable dtThongTinBaoCao = quanLyBaoCaoBUS.LayThongTinBaoCaoDocGiaNoTienPhat(NgayLapBaoCao);


                dgvBaoCaoDocGiaNoTienPhat.DataSource = dtThongTinBaoCao;
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
