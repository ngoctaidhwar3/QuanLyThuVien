using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using BUS.DocGiaBUS;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangQuanLyDocGia : UserControl
    {
        DataTable dsDocGia;
        int LanDauDoDuLieu = 0;
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangQuanLyDocGia(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private void Tai_Thong_Tin()
        {

            DocGiaBUS docGiaBUS = new DocGiaBUS();
            dsDocGia = docGiaBUS.LayDanhSachDocGia();

            if (LanDauDoDuLieu == 0)
            {

               

                TinhTrangDocGiaBUS tinhTrangDocGiaBUS = new TinhTrangDocGiaBUS();
                DataTable dsTTDG = tinhTrangDocGiaBUS.LayDanhSachTinhTrangDocGia();
                

                DataGridViewComboBoxColumn dgvComboTinhTrangDocGia = new DataGridViewComboBoxColumn();
                dgvComboTinhTrangDocGia.DataSource = dsTTDG;
                dgvComboTinhTrangDocGia.DisplayMember = dsTTDG.Columns[1].ColumnName;
                dgvComboTinhTrangDocGia.ValueMember = dsTTDG.Columns[0].ColumnName;
                dgvComboTinhTrangDocGia.DataPropertyName = "TTDG";
                dgvComboTinhTrangDocGia.HeaderText = "Tình Trạng";
                dgvComboTinhTrangDocGia.Width = 50;

                dgvDanhSachDocGia.Columns.Add(dgvComboTinhTrangDocGia);

                LanDauDoDuLieu++;
            }
            dgvDanhSachDocGia.DataSource = dsDocGia;
        }

        private void ManHinhChucNangQuanLyDocGia_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            dgvDanhSachDocGia.Update();
            DataTable dataTableUpdate = new DataTable();
            dataTableUpdate = dsDocGia.GetChanges();
            if (dataTableUpdate != null)
            {
                DocGiaBUS docGiaBUS = new DocGiaBUS();
                docGiaBUS.CapNhatDocGia(dataTableUpdate);
                Tai_Thong_Tin();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }
    }
}
