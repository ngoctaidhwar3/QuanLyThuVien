using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MenuChucNang
{
    public partial class MenuChucNangExportImport : UserControl
    {
        int Speed = 1;
        public MenuChucNangExportImport()
        {
            InitializeComponent();
        }

        private void MenuChucNangExportImport_Load(object sender, EventArgs e)
        {
            pnChucNangExportImport.Location = new Point(-pnChucNangExportImport.Width, 0);
            timerAnimationSlide.Start();
        }

        private void timerAnimationSlide_Tick(object sender, EventArgs e)
        {
            int X = pnChucNangExportImport.Location.X + Speed;
            int Y = pnChucNangExportImport.Location.Y;

            if (X > 0 || Speed < 0)
            {
                X = 0;
                timerAnimationSlide.Stop();
            }

            pnChucNangExportImport.Location = new Point(X, Y);

            if (X < -pnChucNangExportImport.Width / 2)
                Speed++;
            else
            {
                Speed--;
                timerAnimationSlide.Interval = 30;
            }
        }
    }
}
