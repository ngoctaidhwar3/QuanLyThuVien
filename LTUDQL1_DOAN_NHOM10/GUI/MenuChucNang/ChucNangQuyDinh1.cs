using System;
using System.Drawing;
using System.Windows.Forms;
using static GUI.MenuForm;

namespace GUI.MenuChucNang
{
    public partial class MenuChucNangQuyDinh1 : UserControl
    {
        HamChuyenTrang ChuyenTrang;
        int Speed = 1;
        HamChuyenTrang ChuyenManHinhChucNang;
        public MenuChucNangQuyDinh1(HamChuyenTrang ChuyenTrang, HamChuyenTrang ChuyenManHinhChucNang)
        {
            InitializeComponent();
            this.ChuyenTrang = ChuyenTrang;
            this.ChuyenManHinhChucNang = ChuyenManHinhChucNang;
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangQuyDinh1.Location.X + Speed;
            int Y = pnChucNangQuyDinh1.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }

            pnChucNangQuyDinh1.Location = new Point(X, Y);

            if (X < -pnChucNangQuyDinh1.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }
        }

        private void MenuChucNangQuyDinh1_Load(object sender, EventArgs e)
        {
            pnChucNangQuyDinh1.Location = new Point(-pnChucNangQuyDinh1.Width, 0);
            timerAnimationSlide.Start();
        }

        private void btnTrang2_Click_1(object sender, EventArgs e)
        {
            this.ChuyenTrang(2);
        }

        private void btnItemCapNhatQuyDinh_Click(object sender, EventArgs e)
        {

            this.ChuyenManHinhChucNang(15);
        }

        private void btnItemCapNhatBangCap_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(16);
        }


        private void btnItemCapNhatLoaiDocGia_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(17);
        }

        private void btnItemCapNhatLyDoThanhLy_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(19);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(18);
        }
    }
}