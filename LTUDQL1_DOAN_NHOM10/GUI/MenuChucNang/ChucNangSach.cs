using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.MenuForm;

namespace GUI.MenuChucNang
{
    public partial class MenuChucNangSach : UserControl
    {
        int Speed = 1;
        HamChuyenTrang ChuyenManHinhChucNang;

        public MenuChucNangSach(HamChuyenTrang ChuyenManHinhChucNang)
        {
            InitializeComponent();
            this.ChuyenManHinhChucNang = ChuyenManHinhChucNang;
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangSach.Location.X + Speed;
            int Y = pnChucNangSach.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }

            pnChucNangSach.Location = new Point(X, Y);

            if (X < -pnChucNangSach.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }
        }

        private void MenuChucNangSach_Load(object sender, EventArgs e)
        {
            pnChucNangSach.Location = new Point(-pnChucNangSach.Width, 0);
            timerAnimationSlide.Start();
        }

        private void btnItemTiepNhanSachMoi_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(3);
        }

        private void btnItemTraCuuSach_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(4);
        }

      

        private void btnItemNhanTraSach_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(6);
        }

        private void btnItemGhiNhanMatSach_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(8);
        }

        private void btnItemThanhLySach_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(9);
        }

        private void btnItemChoMuonSach_Click(object sender, EventArgs e)
        {
            this.ChuyenManHinhChucNang(5);
        }
    }
}
