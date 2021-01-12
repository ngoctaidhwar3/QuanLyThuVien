using System;
using System.Data;
using System.Windows.Forms;
using static GUI.MenuForm;
using BUS;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangTiepNhanSachMoi : UserControl
    {
        const int bookIdLength = 8;
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangTiepNhanSachMoi(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private string GenerateBookId()
        {
            DataTable dataTable = BUS.SachBUS.GetDatasByCommand("select top 1 * from SACH order by MaSach DESC");
            int oldBookId = int.Parse(dataTable.Rows[0][0].ToString().Substring(1, 3));
            oldBookId++;

            string newBookId = "S" + oldBookId.ToString("000");
            return newBookId;
        }

        private void LoadComboBoxesData()
        {
            DataTable dataTable = BUS.SachBUS.GetDatasByCommand("SELECT MaTheLoai, TenTheLoai FROM TheLoaiSach");
            cbCategory.DataSource = dataTable;
            cbCategory.DisplayMember = "TenTheLoai";
            cbCategory.ValueMember = "MaTheLoai";

            dataTable = BUS.SachBUS.GetDatasByCommand("SELECT MaTacGia, TenTacGia FROM TACGIA");
            cbAuthor.DataSource = dataTable;
            cbAuthor.DisplayMember = "TenTacGia";
            cbAuthor.ValueMember = "MaTacGia";

            dataTable = BUS.SachBUS.GetDatasByCommand("SELECT MaNXB, TenNXB FROM NHAXUATBAN");
            cbPublisher.DataSource = dataTable;
            cbPublisher.DisplayMember = "TenNXB";
            cbPublisher.ValueMember = "MaNXB";

            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            dataTable = nhanVienBUS.LayDanhSachNhanVienTheoBoPhan("BP03");
            cbbTaker.DataSource = dataTable;
            cbbTaker.DisplayMember = "HoTenNV";
            cbbTaker.ValueMember = "MaNhanVien";
        }

        private void ManHinhChucNangTiepNhanSachMoi_Load(object sender, EventArgs e)
        {
            string bookId = GenerateBookId();

            
            while (BUS.SachBUS.WasExistBookId(bookId))
            {
                bookId = GenerateBookId();
            }

            txtBookId.Text = bookId;
            LoadComboBoxesData();
        }

        private bool IsValidTextBox()
        {
            if (txtTitle.Text == null)
            {
                MessageBox.Show("Tên sách không được trống!");
                return false;
            }

            if (txtPrice.Text == null)
            {
                MessageBox.Show("Giá tiền của sách không được trống!");
                return false;
            }

            if (txtPosition.Text == null)
            {
                MessageBox.Show("Vị trí của sách không được trống!");
                return false;
            }

            return true;
        }

        
        private void OnlyNumberEvent(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (!IsValidTextBox())
            {
                return;
            }

            DTO.Sach book = new DTO.Sach
            {
                Ma = GenerateBookId(),
                Ten = txtTitle.Text,
                MaTheLoai = cbCategory.SelectedValue.ToString(),
                MaTacGia = cbAuthor.SelectedValue.ToString(),
                MaMXB = cbPublisher.SelectedValue.ToString(),
                NgayXuatBan = dtpPublicationDate.Value,
                GiaTien = double.Parse(txtPrice.Text),
                ViTri = txtPosition.Text,
                NgayTiepNhan = dtpReceivedDate.Value,
                MaNVTiepNhan = cbbTaker.SelectedValue.ToString()
            };

            int result = BUS.SachBUS.AddANewBook(book);

            if (1 == result)
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }

            txtTitle.Text = "";
            txtPosition.Text = "";
            txtPrice.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtPosition.Text = "";
            txtPrice.Text = "";
        }
    }
}
