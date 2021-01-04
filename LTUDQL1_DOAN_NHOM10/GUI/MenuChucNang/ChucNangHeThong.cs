using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuChucNangHeThong : UserControl
    {
        int Speed = 1;
        public MenuChucNangHeThong()
        {
            InitializeComponent();
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangHeThong.Location.X + Speed;
            int Y = pnChucNangHeThong.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }



            pnChucNangHeThong.Location = new Point(X, Y);

            if (X < -pnChucNangHeThong.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }

        }

        private void MenuChucNangHeThong_Load(object sender, EventArgs e)
        {
            pnChucNangHeThong.Location = new Point(-pnChucNangHeThong.Width, 0);

            timerAnimationSlide.Start();
        }

    }
}
