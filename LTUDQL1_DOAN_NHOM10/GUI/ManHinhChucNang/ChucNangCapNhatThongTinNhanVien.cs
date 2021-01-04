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

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangCapNhatThongTinNhanVien : UserControl
    {
        public ManHinhChucNangCapNhatThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void Tai_Thong_Tin_Bang_Cap()
        {
            
            BangCapBUS BangCapBUS = new BangCapBUS();
            DataTable dsBangCap = BangCapBUS.LayDanhSachBangCap();

            dgvBangCap.DataSource = dsBangCap;

        }
        private void Tai_Thong_Tin_Chuc_Vu()
        {
            
            ChucVuBUS ChucVuBUS = new ChucVuBUS();
            DataTable dsChucVu = ChucVuBUS.LayDanhSachChucVu();

            dgvChucVu.DataSource = dsChucVu;
        }

        private void Tai_Thong_Tin_Bo_Phan()
        {
            

            BoPhanBUS BoPhanBUS = new BoPhanBUS();
            DataTable dsBoPhan = BoPhanBUS.LayDanhSachBoPhan();

            dgvBoPhan.DataSource = dsBoPhan;
        }
        private void Tai_Thong_Tin_Tinh_Trang()
        {
           

            TinhTrangNhanVienBUS tinhTrangNhanVienBUS = new TinhTrangNhanVienBUS();
            DataTable dsTTNV = tinhTrangNhanVienBUS.LayDanhSachTinhTrangNhanVien();
            dgvTinhTrang.DataSource = dsTTNV;
        }


        private void ManHinhChucNangCapNhatThongTinNhanVien_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin_Bang_Cap();
            Tai_Thong_Tin_Bo_Phan();
            Tai_Thong_Tin_Chuc_Vu();
            Tai_Thong_Tin_Tinh_Trang();
        }

        private void dgvChucVu_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvChucVu.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvChucVu.SelectedRows[0];
                txtMaChucVu.Text = Row.Cells[0].Value.ToString();
                txtTenChucVu.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dgvBangCap_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvBangCap.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvBangCap.SelectedRows[0];
                txtMaBangCap.Text = Row.Cells[0].Value.ToString();
                txtTenBangCap.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dgvTinhTrang_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvTinhTrang.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvTinhTrang.SelectedRows[0];
                txtMaTinhTrang.Text = Row.Cells[0].Value.ToString();
                txtTenTinhTrang.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dgvBoPhan_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvBoPhan.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvBoPhan.SelectedRows[0];
                txtMaBoPhan.Text = Row.Cells[0].Value.ToString();
                txtTenBoPhan.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void btnThemBangCap_Click(object sender, EventArgs e)
        {
            try
            {

                BangCapBUS bangCapBUS = new BangCapBUS();
                bangCapBUS.ThemBangCap(txtTenBangCap.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Bang_Cap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }

        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {

            try
            {

                ChucVuBUS ChucVuBUS = new ChucVuBUS();
                ChucVuBUS.ThemChucVu(txtTenChucVu.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Chuc_Vu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {

            try
            {

                BoPhanBUS BoPhanBUS = new BoPhanBUS();
                BoPhanBUS.ThemBoPhan(txtTenBoPhan.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Bo_Phan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnThemTinhTrang_Click(object sender, EventArgs e)
        {

            try
            {

                TinhTrangNhanVienBUS TinhTrangBUS = new TinhTrangNhanVienBUS();
                TinhTrangBUS.ThemTinhTrang(txtTenTinhTrang.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Tinh_Trang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnSuaBangCap_Click(object sender, EventArgs e)
        {

            try
            {

                BangCapBUS bangCapBUS = new BangCapBUS();
                bangCapBUS.SuaBangCap(txtTenBangCap.Text, txtMaBangCap.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Bang_Cap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaBangCap_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa bằng " + txtTenBangCap.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Ignore:
                        return;
                        break;
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        BangCapBUS bangCapBUS = new BangCapBUS();
                        bangCapBUS.XoaBangCap(txtMaBangCap.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Bang_Cap();
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

        private void btnSuaChucVu_Click(object sender, EventArgs e)
        {

            try
            {

                ChucVuBUS ChucVuBUS = new ChucVuBUS();
                ChucVuBUS.SuaChucVu(txtTenChucVu.Text, txtMaChucVu.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Chuc_Vu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaChucVu_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa Chức vụ " + txtTenChucVu.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Ignore:
                        return;
                        break;
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        ChucVuBUS ChucVuBUS = new ChucVuBUS();
                        ChucVuBUS.XoaChucVu(txtMaChucVu.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Chuc_Vu();
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

        private void btnSuaBoPhan_Click(object sender, EventArgs e)
        {
            try
            {

                BoPhanBUS BoPhanBUS = new BoPhanBUS();
                BoPhanBUS.SuaBoPhan(txtTenBoPhan.Text, txtMaBoPhan.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Bo_Phan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaBoPhan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa bộ phận " + txtTenBoPhan.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Ignore:
                        return;
                        break;
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        BoPhanBUS BoPhanBUS = new BoPhanBUS();
                        BoPhanBUS.XoaBoPhan(txtMaBoPhan.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Bo_Phan();
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

        private void btnSuaTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {

                TinhTrangNhanVienBUS TinhTrangBUS = new TinhTrangNhanVienBUS();
                TinhTrangBUS.SuaTinhTrang(txtTenTinhTrang.Text, txtMaTinhTrang.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Tinh_Trang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa tình trạng: " + txtTenTinhTrang.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Ignore:
                        return;
                        break;
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        TinhTrangNhanVienBUS TinhTrangBUS = new TinhTrangNhanVienBUS();
                        TinhTrangBUS.XoaTinhTrang(txtMaTinhTrang.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Tinh_Trang();
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
