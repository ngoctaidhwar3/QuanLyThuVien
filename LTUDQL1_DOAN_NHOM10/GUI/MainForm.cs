using System;
using System.Drawing;
using System.Windows.Forms;
using static GUI.MenuForm;

namespace GUI
{
    public partial class MainForm : UserControl
    {
        public HamChuyenTrang ChuyenTrangChucNang;

        int Speed = 1;

        int oldWidthFlowForm;
        int oldHeightFlowForm;

        int oldWidthFlowFormWrapper;
        int oldHeightFlowFormWrapper;
        public MainForm()
        {
            InitializeComponent();

            oldWidthFlowForm = flpnChucNangChinh.Width;
            oldHeightFlowForm = flpnChucNangChinh.Height;

            oldWidthFlowFormWrapper = panel13.Width;
            oldHeightFlowFormWrapper = panel13.Height;
             
            this.Dock = DockStyle.Fill;
        }
        public MainForm(HamChuyenTrang ChuyenTrangChucNang)
        {
            InitializeComponent();

            oldWidthFlowForm = flpnChucNangChinh.Width;
            oldHeightFlowForm = flpnChucNangChinh.Height;

            oldWidthFlowFormWrapper = panel13.Width;
            oldHeightFlowFormWrapper = panel13.Height;

            this.Dock = DockStyle.Fill;

            this.ChuyenTrangChucNang = ChuyenTrangChucNang;
        }  

        private void MainForm_Load(object sender, EventArgs e)
        {
            flpnChucNangChinh.Location = new Point(0, panel13.Height);
            timerAnimation.Start();
        }

        private void panel13_SizeChanged(object sender, EventArgs e)
        {
            int IncreaseWidth = panel13.Width - oldWidthFlowFormWrapper;
            int IncreaseHeight = panel13.Height - oldHeightFlowFormWrapper;

            flpnChucNangChinh.Width += IncreaseWidth;
            flpnChucNangChinh.Height += IncreaseHeight;

            oldWidthFlowFormWrapper = panel13.Width;
            oldHeightFlowFormWrapper = panel13.Height;
        }

        private void flpnChucNangChinh_SizeChanged(object sender, EventArgs e)
        {
            int IncreaseWidth = flpnChucNangChinh.Width - oldWidthFlowForm;
            int IncreaseHeight = flpnChucNangChinh.Height - oldHeightFlowForm;

            foreach (Control itemControl in flpnChucNangChinh.Controls)
            {
                if (itemControl is Panel)
                {
                    itemControl.Width += IncreaseWidth / 200;
                    itemControl.Height += IncreaseHeight / 100;
                }

            }


            oldWidthFlowForm = flpnChucNangChinh.Width;
            oldHeightFlowForm = flpnChucNangChinh.Height;
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            int X = flpnChucNangChinh.Location.X;
            int Y = flpnChucNangChinh.Location.Y - Speed;

            if (Y < 0 || Speed < 0)
            {
                Y = 0;
                timerAnimation.Stop();
            }

            flpnChucNangChinh.Location = new Point(X, Y);

            if (Y >= panel13.Height / 4)
                Speed++;
            else
            {
                Speed--;
                timerAnimation.Interval = 30;
            }
        }

        private void btnTiepNhanNhanVien_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(1);
        }

        private void btnLapTheDocGia_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(2);
        }

        private void btnTiepNhanSachMoi_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(3);
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(4);
        }

        private void btnChoMuonSach_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(5);
        }

        private void btnNhanTraSach_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(6);
        }

        private void btnLapPhieuThuTienPhat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(7);
        }

        private void btnGhiNhanMatSach_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(8);
        }

        private void btnThanhLySach_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(9);
        }

        private void btnBaoCaoTheoTheLoai_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(10);
        }

        private void btnBaoCaoSachTraTre_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(11);
        }

        private void btnBaoCaoDocGiaNoTienPhat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChucNang(12);
        }
    }
}
