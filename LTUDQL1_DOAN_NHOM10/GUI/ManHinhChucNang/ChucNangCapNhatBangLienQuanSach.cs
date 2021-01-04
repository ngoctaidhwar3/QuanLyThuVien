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
    public partial class ManHinhChucNangCapNhatBangLienQuanSach : UserControl
    {
        public ManHinhChucNangCapNhatBangLienQuanSach()
        {
            InitializeComponent();
        }

        private void LoadDanhSachTheLoaiSach()
        {
            TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
            DataTable dsTheLoai = TheLoaiBUS.LayDanhSachTheLoai();

            dtgridviewTheLoaiSach.DataSource = dsTheLoai;

        }

        private void LoadDanhSachTacGia()
        {
            
            TacGiaBUS TacGiaBUS = new TacGiaBUS();
            DataTable dsTacGia = TacGiaBUS.LayDanhSachTacGia();

            dtgridviewTacGia.DataSource = dsTacGia;

        }

        private void LoadDanhSachNXB()
        {
            
            NXBBUS NXBBUS = new NXBBUS();
            DataTable dsNXB = NXBBUS.LayDanhSachNXB();
            dtgridviewNXB.DataSource = dsNXB;

        }

        private void LoadDanhSachTinhTrangSach()
        {
            
            TinhTrangSachBUS TTSBUS = new TinhTrangSachBUS();
            DataTable dsTTS = TTSBUS.LayDanhSachTinhTrangSach();
            dtgridviewTTS.DataSource = dsTTS;

        }

        private void ManHinhChucNangCapNhatBangLienQuanSach_Load(object sender, EventArgs e)
        {
            LoadDanhSachTheLoaiSach();
            LoadDanhSachTacGia();
            LoadDanhSachNXB();
            LoadDanhSachTinhTrangSach();
        }

        private void dtgridviewTheLoaiSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgridviewTheLoaiSach.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgridviewTheLoaiSach.SelectedRows[0];
                txtMaTL.Text = Row.Cells[0].Value.ToString();
                txtTenTheLoai.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dtgridviewTacGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgridviewTacGia.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgridviewTacGia.SelectedRows[0];
                txtMaTG.Text = Row.Cells[0].Value.ToString();
                txtTenTG.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dtgridviewNXB_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgridviewNXB.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgridviewNXB.SelectedRows[0];
                txtMaNXB.Text = Row.Cells[0].Value.ToString();
                txtTenNXB.Text = Row.Cells[1].Value.ToString();
            }
        }

        private void dtgridviewTTS_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgridviewTTS.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgridviewTTS.SelectedRows[0];
                txtMaTTS.Text = Row.Cells[0].Value.ToString();
                txtTenTTS.Text = Row.Cells[1].Value.ToString();
            }
        }

       
        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập tên thể loại !!!", "THÔNG BÁO");
                txtTenTheLoai.Focus();
                return;
            }
            try
            {
                TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
                TheLoaiBUS.ThemTheLoai(txtTenTheLoai.Text);
                MessageBox.Show("Thêm thành công");
                LoadDanhSachTheLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không ??", "Xóa thể loại " + txtTenTheLoai.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
                        TheLoaiBUS.XoaTheLoai(txtMaTL.Text);
                        MessageBox.Show("Xóa thành công");
                        LoadDanhSachTheLoaiSach();
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

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTheLoai.Text != "")
                {
                    TheLoaiBUS TheLoaiBUS = new TheLoaiBUS();
                    TheLoaiBUS.SuaTheLoai(txtMaTL.Text, txtTenTheLoai.Text);
                    MessageBox.Show("Cập nhật thành công", "THÔNG BÁO");
                    LoadDanhSachTheLoaiSach();
                }
                else
                {
                    MessageBox.Show("Xin vui lòng nhập tên thể loại !!!", "THÔNG BÁO");
                    txtTenTheLoai.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }


        
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            if (txtTenTG.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập tên tác giả !!!", "THÔNG BÁO");
                txtTenTG.Focus();
                return;
            }
            try
            {
                TacGiaBUS TacGiaBUS = new TacGiaBUS();
                TacGiaBUS.ThemTacGia(txtTenTG.Text);
                MessageBox.Show("Thêm thành công");
                LoadDanhSachTacGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không ??", "Xóa tác giả " + txtTenTG.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        TacGiaBUS TacGiaBUS = new TacGiaBUS();
                        TacGiaBUS.XoaTacGia(txtMaTG.Text);
                        MessageBox.Show("Xóa thành công");
                        LoadDanhSachTacGia();
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

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTG.Text != "")
                {
                    TacGiaBUS TacGiaBUS = new TacGiaBUS();
                    TacGiaBUS.SuaTacGia(txtMaTG.Text, txtTenTG.Text);
                    MessageBox.Show("Cập nhật thành công", "THÔNG BÁO");
                    LoadDanhSachTacGia();
                }
                else
                {
                    MessageBox.Show("Xin vui lòng nhập tên thể loại !!!", "THÔNG BÁO");
                    txtTenTG.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }



     
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập tên nhà xuất bản !!!", "THÔNG BÁO");
                txtTenNXB.Focus();
                return;
            }
            try
            {
                NXBBUS NXBBUS = new NXBBUS();
                NXBBUS.ThemNXB(txtTenNXB.Text);
                MessageBox.Show("Thêm thành công");
                LoadDanhSachNXB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không ??", "Xóa nhà xuất bản " + txtTenNXB.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        NXBBUS NXBBUS = new NXBBUS();
                        NXBBUS.XoaNXB(txtMaNXB.Text);
                        MessageBox.Show("Xóa thành công");
                        LoadDanhSachNXB();
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

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNXB.Text != "")
                {
                    NXBBUS NXBBUS = new NXBBUS();
                    NXBBUS.SuaNXB(txtMaNXB.Text, txtTenNXB.Text);
                    MessageBox.Show("Cập nhật thành công", "THÔNG BÁO");
                    LoadDanhSachNXB();
                }
                else
                {
                    MessageBox.Show("Xin vui lòng nhập tên nhà xuất bản !!!", "THÔNG BÁO");
                    txtTenNXB.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }


        private void btnThemTinhTrang_Click(object sender, EventArgs e)
        {
            if (txtTenTTS.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập tên tác giả !!!", "THÔNG BÁO");
                txtTenTTS.Focus();
                return;
            }
            try
            {
                TinhTrangSachBUS TTSBUS = new TinhTrangSachBUS();
                TTSBUS.ThemTinhTrangSach(txtTenTTS.Text);
                MessageBox.Show("Thêm thành công");
                LoadDanhSachTinhTrangSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại - Lỗi :" + ex.ToString());
            }
        }

        private void btnXoaTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không ??", "Xóa tình trạng sách " + txtTenTTS.Text, MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        return;
                        break;
                    case DialogResult.Yes:
                        TinhTrangSachBUS TTSBUS = new TinhTrangSachBUS();
                        TTSBUS.XoaTinhTrangSach(txtMaTTS.Text);
                        MessageBox.Show("Xóa thành công");
                        LoadDanhSachTinhTrangSach();
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
                if (txtTenTTS.Text != "")
                {
                    TinhTrangSachBUS TTSBUS = new TinhTrangSachBUS();
                    TTSBUS.SuaTinhTrangSach(txtMaTTS.Text, txtTenTTS.Text);
                    MessageBox.Show("Cập nhật thành công", "THÔNG BÁO");
                    LoadDanhSachTinhTrangSach();
                }
                else
                {
                    MessageBox.Show("Xin vui lòng nhập tên tình trạng sách !!!", "THÔNG BÁO");
                    txtTenTTS.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại - Lỗi :" + ex.ToString());
            }
        }

    }
}
