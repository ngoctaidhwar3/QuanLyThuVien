using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangCapNhatBangLienQuanDocGia : UserControl
    {
        public ManHinhChucNangCapNhatBangLienQuanDocGia()
        {
            InitializeComponent();
        }

        private void Tai_Thong_Tin_Loai_DG()
        {
            LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();
            DataTable dsLoaiDG = loaiDocGiaBUS.LayDanhSachLoaiDocGia();
            dgvLoaiDocGia.DataSource = dsLoaiDG;
        }
        private void Tai_Thong_Tin_Tinh_Trang_DG()
        {
            TinhTrangDocGiaBUS tinhTrangDocGia = new TinhTrangDocGiaBUS();
            DataTable dsTTDG = tinhTrangDocGia.LayDanhSachTinhTrangDocGia();
            dgvTinhTrangDG.DataSource = dsTTDG;
        }
        private void ManHinhChucNangCapNhatBangLienQuanDocGia_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin_Loai_DG();
            Tai_Thong_Tin_Tinh_Trang_DG();
        }

        private void dgvLoaiDocGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiDocGia.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvLoaiDocGia.SelectedRows[0];
                txtMaLoaiDG.Text = Row.Cells[0].Value.ToString();
                txtTenLoaiDG.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dgvTinhTrangDG_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTinhTrangDG.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvTinhTrangDG.SelectedRows[0];
                txtMaTinhTrangDG.Text = Row.Cells[0].Value.ToString();
                txtTenTinhTrangDG.Text = Row.Cells[1].Value.ToString();
            }

        }

        private void btnThemLoaiDG_Click(object sender, EventArgs e)
        {

            try
            {

                LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();
                loaiDocGiaBUS.ThemLoaiDocGia(txtTenLoaiDG.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Loai_DG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }

        }

        private void btnSuaLoaiDG_Click(object sender, EventArgs e)
        {

            try
            {

                LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();
                loaiDocGiaBUS.SuaLoaiDocGia(txtTenLoaiDG.Text, txtMaLoaiDG.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Loai_DG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaLoaiDG_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa Loại độc giả: " + txtTenLoaiDG.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        LoaiDocGiaBUS LoaiDocGiaBUS = new LoaiDocGiaBUS();
                        LoaiDocGiaBUS.XoaLoaiDocGia(txtMaLoaiDG.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Loai_DG();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại - Lỗi :" + ex.ToString());
            }


        }

        private void btnThemTinhTrangDG_Click(object sender, EventArgs e)
        {
            try
            {

                TinhTrangDocGiaBUS tinhTrangDocGiaBUS = new TinhTrangDocGiaBUS();
                tinhTrangDocGiaBUS.ThemTinhTrangDG(txtTenTinhTrangDG.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Tinh_Trang_DG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnSuaTinhTrangDG_Click(object sender, EventArgs e)
        {
            try
            {

                TinhTrangDocGiaBUS tinhTrangDocGiaBUS = new TinhTrangDocGiaBUS();
                tinhTrangDocGiaBUS.SuaTinhTrangDG(txtTenTinhTrangDG.Text, txtMaTinhTrangDG.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Tinh_Trang_DG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaTinhTrangDG_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa Tình trạng: " + txtTenTinhTrangDG.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        TinhTrangDocGiaBUS tinhTrangDocGiaBUS = new TinhTrangDocGiaBUS();
                        tinhTrangDocGiaBUS.XoaTinhTrangDG(txtMaTinhTrangDG.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Tinh_Trang_DG();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại - Lỗi :" + ex.ToString());
            }

        }
    }
}
