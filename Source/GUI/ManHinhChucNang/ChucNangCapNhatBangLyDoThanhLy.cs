using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangCapNhatBangLyDoThanhLy : UserControl
    {
        public ManHinhChucNangCapNhatBangLyDoThanhLy()
        {
            InitializeComponent();
        }

        private void Tai_Thong_Tin_Ly_Do()
        {
            QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
            DataTable dsLyDo = quanLyThanhLySachBUS.LayDanhSachLyDoThanhLy();
            dgvLyDoThanhLySach.DataSource = dsLyDo;
        }

        private void ManHinhChucNangCapNhatBangLyDoThanhLy_Load(object sender, EventArgs e)
        {
            Tai_Thong_Tin_Ly_Do();
        }

        private void dgvLyDoThanhLySach_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvLyDoThanhLySach.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dgvLyDoThanhLySach.SelectedRows[0];
                txtMaLyDo.Text = Row.Cells[0].Value.ToString();
                txtMoTa.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void btnThemLyDo_Click(object sender, EventArgs e)
        {

            try
            {

                QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
                quanLyThanhLySachBUS.ThemQuanLyThanhLySach(txtMoTa.Text);
                MessageBox.Show("Thêm thành công");
                Tai_Thong_Tin_Ly_Do();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnSuaLyDo_Click(object sender, EventArgs e)
        {

            try
            {

                QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
                quanLyThanhLySachBUS.SuaQuanLyThanhLySach(txtMoTa.Text, txtMaLyDo.Text);
                MessageBox.Show("Cập nhật thành công");
                Tai_Thong_Tin_Ly_Do();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaLyDo_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa ??", "Xóa lý do ", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
                        quanLyThanhLySachBUS.XoaQuanLyThanhLySach(txtMaLyDo.Text);
                        MessageBox.Show("Xóa thành công");
                        Tai_Thong_Tin_Ly_Do();
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
