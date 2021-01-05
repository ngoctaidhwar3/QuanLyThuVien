using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangQuanLyNhanVien : UserControl
    {
        DataTable dsNhanVien;
        int LanDauDoDuLieu = 0;
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangQuanLyNhanVien(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }
        void Tai_Thong_Tin()
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            dsNhanVien = nhanVienBUS.LayDanhSachNhanVien();

            if (LanDauDoDuLieu == 0)
            {

                

                TinhTrangNhanVienBUS tinhTrangNhanVienBUS = new TinhTrangNhanVienBUS();
                DataTable dsTTNV = tinhTrangNhanVienBUS.LayDanhSachTinhTrangNhanVien();

                DataGridViewComboBoxColumn dgvComboTinhTrangNhanVien = new DataGridViewComboBoxColumn();
                dgvComboTinhTrangNhanVien.DataSource = dsTTNV;
                dgvComboTinhTrangNhanVien.DisplayMember = dsTTNV.Columns[1].ColumnName;
                dgvComboTinhTrangNhanVien.ValueMember = dsTTNV.Columns[0].ColumnName;
                dgvComboTinhTrangNhanVien.DataPropertyName = "MaTTNV";
                dgvComboTinhTrangNhanVien.HeaderText = "Tình Trạng";
                dgvComboTinhTrangNhanVien.Width = 50;

                dgvDanhSachNhanVien.Columns.Add(dgvComboTinhTrangNhanVien);

                
                BangCapBUS bangCapBUS = new BangCapBUS();
                DataTable dsBangCap = bangCapBUS.LayDanhSachBangCap();

                
                DataGridViewComboBoxColumn dgvComboBangCap = new DataGridViewComboBoxColumn();
                dgvComboBangCap.DataSource = dsBangCap;
                dgvComboBangCap.DisplayMember = dsBangCap.Columns[1].ColumnName;
                dgvComboBangCap.ValueMember = dsBangCap.Columns[0].ColumnName;
                dgvComboBangCap.DataPropertyName = "MaBangCap";
                dgvComboBangCap.HeaderText = "Bằng cấp";
                dgvComboBangCap.Width = 50;

                dgvDanhSachNhanVien.Columns.Add(dgvComboBangCap);


                
                BoPhanBUS boPhanBUS = new BoPhanBUS();
                DataTable dsBoPhan = boPhanBUS.LayDanhSachBoPhan();

               
                DataGridViewComboBoxColumn dgvComboBoPhan = new DataGridViewComboBoxColumn();
                dgvComboBoPhan.DataSource = dsBoPhan;
                dgvComboBoPhan.DisplayMember = dsBoPhan.Columns[1].ColumnName;
                dgvComboBoPhan.ValueMember = dsBoPhan.Columns[0].ColumnName;
                dgvComboBoPhan.DataPropertyName = "MaBoPhan";
                dgvComboBoPhan.HeaderText = "Bộ phận";
                dgvComboBoPhan.Width = 50;

                dgvDanhSachNhanVien.Columns.Add(dgvComboBoPhan);
               
                ChucVuBUS chucVuBUS = new ChucVuBUS();
                DataTable dsChucVu = chucVuBUS.LayDanhSachChucVu();

                
                DataGridViewComboBoxColumn dgvComboChucVu = new DataGridViewComboBoxColumn();
                dgvComboChucVu.DataSource = dsChucVu;
                dgvComboChucVu.DisplayMember = dsChucVu.Columns[1].ColumnName;
                dgvComboChucVu.ValueMember = dsChucVu.Columns[0].ColumnName;
                dgvComboChucVu.DataPropertyName = "MaChucVu";
                dgvComboChucVu.HeaderText = "Chức vụ";
                dgvComboChucVu.Width = 50;
                dgvDanhSachNhanVien.Columns.Add(dgvComboChucVu);

                LanDauDoDuLieu++;
            }
            dgvDanhSachNhanVien.DataSource = dsNhanVien;

        }



        private void ManHinhChucNangQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.Update();
            DataTable dataTableUpdate = new DataTable();
            dataTableUpdate = dsNhanVien.GetChanges();
            if (dataTableUpdate != null)
            {
                NhanVienBUS nhanVienBUS = new NhanVienBUS();
                nhanVienBUS.CapNhatNhanVien(dataTableUpdate);
                Tai_Thong_Tin();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.ChuyenTrangChu(0);
        }
    }
}
