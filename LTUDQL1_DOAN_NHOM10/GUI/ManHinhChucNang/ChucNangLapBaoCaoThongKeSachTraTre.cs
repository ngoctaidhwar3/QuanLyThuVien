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
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangLapBaoCaoThongKeSachTraTre : UserControl
    {
        HamChuyenTrang ChuyenTrangChu;

        public ManHinhChucNangLapBaoCaoThongKeSachTraTre(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvBaoCaoSachTraTre.Rows.Count; i++)
            {
                dgvBaoCaoSachTraTre[0, i].Value = i + 1;
            }
        }


        private void ManHinhChucNangLapBaoCaoThongKeSachTraTre_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }

        private void ManHinhChucNangLapBaoCaoThongKeSachTraTre_SizeChanged(object sender, EventArgs e)
        {
            pnWrapperBaoCao.Location = new Point(this.Width / 2 - pnWrapperBaoCao.Width / 2, pnWrapperBaoCao.Location.Y);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtNgayLapBaoCao.Value = DateTime.Now;

            QuanLyBaoCaoBUS quanLyBaoCaoBUS = new QuanLyBaoCaoBUS();
            DataTable dtThongTinBaoCao = quanLyBaoCaoBUS.LayThongTinBaoCaoSachTraTre("0001-01-01");

            dgvBaoCaoSachTraTre.DataSource = dtThongTinBaoCao;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                string NgayLapBaoCao = dtNgayLapBaoCao.Value.ToString("yyyy-MM-dd");

                QuanLyBaoCaoBUS quanLyBaoCaoBUS = new QuanLyBaoCaoBUS();
                DataTable dtThongTinBaoCao = quanLyBaoCaoBUS.LayThongTinBaoCaoSachTraTre(NgayLapBaoCao);


                dgvBaoCaoSachTraTre.DataSource = dtThongTinBaoCao;
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
