using System;
using System.Drawing;
using System.Windows.Forms;
using static GUI.MenuForm;

namespace GUI.MenuChucNang
{
    public partial class MenuChucNangDocGia : UserControl
    {
        HamChuyenTrang ChuyenManHinhChucNang;
        int Speed = 1;

        public MenuChucNangDocGia(HamChuyenTrang ChuyenManHinhChucNang)
        {
            InitializeComponent();

            this.ChuyenManHinhChucNang = ChuyenManHinhChucNang;
        }

        private void MenuChucNangDocGia_Load(object sender, EventArgs e)
        {
            pnChucNangDocGia.Location = new Point(-pnChucNangDocGia.Width, 0);
            timerAnimationSlide.Start();
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangDocGia.Location.X + Speed;
            int Y = pnChucNangDocGia.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }

            pnChucNangDocGia.Location = new Point(X, Y);

            if (X < -pnChucNangDocGia.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }
        }

        private void btnItemLapTheDocGia_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(2);
        }

        private void btnItemLapPhieuThuTienPhat_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(7);
        }

        private void btnItemQuanLyDocGia_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(14);
        }


    }
}
