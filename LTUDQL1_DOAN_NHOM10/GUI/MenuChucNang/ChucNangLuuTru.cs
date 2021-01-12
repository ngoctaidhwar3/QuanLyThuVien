using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MenuChucNang
{
    public partial class MenuChucNangLuuTru : UserControl
    {
        int Speed = 1;
        public MenuChucNangLuuTru()
        {
            InitializeComponent();
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangLuuTru.Location.X + Speed;
            int Y = pnChucNangLuuTru.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }

            pnChucNangLuuTru.Location = new Point(X, Y);

            if (X < -pnChucNangLuuTru.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }
        }

        private void MenuChucNangLuuTru_Load(object sender, EventArgs e)
        {
            pnChucNangLuuTru.Location = new Point(-pnChucNangLuuTru.Width, 0);
            timerAnimationSlide.Start();
        }
    }
}
