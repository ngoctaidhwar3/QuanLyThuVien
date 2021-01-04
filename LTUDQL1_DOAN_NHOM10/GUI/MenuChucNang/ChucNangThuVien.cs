using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.MainForm;

namespace GUI.MenuChucNang
{
    public partial class MenuChucNangThuVien : UserControl
    {
        int Speed = 1;
        HamChuyenTrang ChuyenManHinhChucNang;

        public MenuChucNangThuVien(HamChuyenTrang ChuyenManHinhChucNang)
        {
            InitializeComponent();

            this.ChuyenManHinhChucNang = ChuyenManHinhChucNang;
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangThuVien.Location.X + Speed;
            int Y = pnChucNangThuVien.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }

            pnChucNangThuVien.Location = new Point(X, Y);

            if (X < -pnChucNangThuVien.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }
        }

        private void MenuChucNangThuVien_Load(object sender, EventArgs e)
        {
            pnChucNangThuVien.Location = new Point(-pnChucNangThuVien.Width, 0);
            timerAnimationSlide.Start();
        }

        private void btnItemTiepNhanNhanVien_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(1);
        }

        private void btnItemLapBaoCaoDocGiaNoTien_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(12);
        }

        private void btnItemLapBaoCaoSachTraTre_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(11);
        }

        private void btnItemLapBaoCaoTheLoai_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(10);
        }

        private void btnItemQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(13);
        }

    }
}
