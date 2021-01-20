using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.DangNhap
{
    public partial class ManHinhDangNhap : UserControl
    {
        int Speed = 1;

        public ManHinhDangNhap()
        {
            InitializeComponent();
        }




        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            int X = pnManHinhDangNhap.Location.X - Speed;
            int Y = pnManHinhDangNhap.Location.Y;

            if (X < 0 || Speed < 0)
            {
                X = 0;
                timerAnimation.Stop();
            }

            pnManHinhDangNhap.Location = new Point(X, Y);

            if (X > pnManHinhDangNhap.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimation.Interval = 30;
            }

        }

        private void ManHinhDangNhap_Load(object sender, EventArgs e)
        {
            pnManHinhDangNhap.Location = new Point(this.Width, 0);
            timerAnimation.Start();
        }
    }
}
