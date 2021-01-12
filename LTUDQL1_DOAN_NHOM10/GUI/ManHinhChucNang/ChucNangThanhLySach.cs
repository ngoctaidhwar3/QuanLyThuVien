using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangThanhLySach : UserControl
    {
        HamChuyenTrang ChuyenTrang;

        DataTable dtNhanVien;

        public ManHinhChucNangThanhLySach(HamChuyenTrang ChuyenTrang)
        {
            InitializeComponent();

            this.ChuyenTrang = ChuyenTrang;
        }


        private void ManHinhChucNangThanhLySach_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;

            LoadDataChiTietThanhLy();
            LoadMaPhieuThanhLy();
            LoadDataNhanVien();
        }

        private void LoadDataNhanVien()
        {
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            dtNhanVien = nhanVienBUS.LayDanhSachNhanVienTheoBoPhan("BP03");

            cbbNhanVien.DataSource = dtNhanVien;
            cbbNhanVien.DisplayMember = "HoTenNV";
            cbbNhanVien.ValueMember = "MaNhanVien";

            for (int i = 0; i < dtNhanVien.Rows.Count; i++)
            {
                if (cbbNhanVien.SelectedValue.ToString() == dtNhanVien.Rows[i][0].ToString())
                {

                    txtNgaySinh.Text = dtNhanVien.Rows[0]["NgaySinh"].ToString();
                }
            }

        }

        private void LoadMaPhieuThanhLy()
        {
            QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
            string MaMoi = quanLyThanhLySachBUS.LayMaPhieuLonNhat();

            txtMaPhieu.Text = MaMoi;
        }



        private void dgvChiTietPhieuThanhLy_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                LoadThongTinSach(e.RowIndex, e.ColumnIndex);
            }
        }

        private bool KiemTraTrungMaSach(string MaSach, int Rowindex)
        {
            for (int i = 0; i < dgvChiTietPhieuThanhLy.Rows.Count - 1; i++)
            {
                if (String.Compare(dgvChiTietPhieuThanhLy[1, i].Value.ToString(), MaSach, true) == 0 && i != Rowindex)
                {
                    return true;
                }
            }

            return false;
        }

        private void LoadThongTinSach(int Rowindex, int Colindex)
        {

            if (dgvChiTietPhieuThanhLy.Rows[Rowindex].Cells[1].Value == null)
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    if (Rowindex != dgvChiTietPhieuThanhLy.Rows.Count - 1)
                        dgvChiTietPhieuThanhLy.Rows.RemoveAt(Rowindex);
                }));


                return;
            }
            string MaSach = dgvChiTietPhieuThanhLy[Colindex, Rowindex].Value.ToString();



            if (KiemTraTrungMaSach(MaSach, Rowindex))
            {
                MessageBox.Show("Mã sách đã được nhập");
                BeginInvoke(new MethodInvoker(delegate
                {
                    if (Rowindex != dgvChiTietPhieuThanhLy.Rows.Count - 1)
                        dgvChiTietPhieuThanhLy.Rows.RemoveAt(Rowindex);
                }));
                return;
            }
            QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
            DataTable dtSach = quanLyThanhLySachBUS.LayThongTinSach(MaSach);

            if (dtSach.Rows.Count < 1) // kiểm tra sách có được tìm thấy hay không
            {
                MessageBox.Show("Không tìm thấy sách với mã " + MaSach);

                BeginInvoke(new MethodInvoker(delegate
                {
                    if (Rowindex != dgvChiTietPhieuThanhLy.Rows.Count - 1)
                        dgvChiTietPhieuThanhLy.Rows.RemoveAt(Rowindex);
                }));

                return;
            }

            dgvChiTietPhieuThanhLy[3, Rowindex].Value = dtSach.Rows[0]["TenSach"].ToString();
            dgvChiTietPhieuThanhLy[4, Rowindex].Value = dtSach.Rows[0]["TenTheLoai"].ToString();
            dgvChiTietPhieuThanhLy[5, Rowindex].Value = dtSach.Rows[0]["TenTacGia"].ToString();

        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvChiTietPhieuThanhLy.Rows.Count; i++)
            {
                dgvChiTietPhieuThanhLy[0, i].Value = i + 1;
            }
        }


        private void dgvChiTietPhieuThanhLy_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvChiTietPhieuThanhLy[0, e.RowIndex].Value = dgvChiTietPhieuThanhLy.Rows.Count;

            LoadLyDoThanhLy(e.RowIndex);
        }


        private void LoadDataChiTietThanhLy()
        {
            LoadLyDoThanhLy(0);
            dgvChiTietPhieuThanhLy[0, 0].Value = dgvChiTietPhieuThanhLy.Rows.Count;
        }

        private void LoadLyDoThanhLy(int i)
        {
            QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
            DataTable dtDSLyDo = quanLyThanhLySachBUS.LayDanhSachLyDoThanhLy();
            dtDSLyDo.Columns["MoTa"].DefaultValue = "Mất";

            var CellLyDoThanhLy = (DataGridViewComboBoxCell)dgvChiTietPhieuThanhLy.Rows[i].Cells[2];
            CellLyDoThanhLy.DataSource = dtDSLyDo;
            CellLyDoThanhLy.DisplayMember = "MoTa";
            CellLyDoThanhLy.ValueMember = "MaLyDoThanhLy";
            CellLyDoThanhLy.Value = dtDSLyDo.Rows[0]["MaLyDoThanhLy"];
        }


        private void dgvChiTietPhieuThanhLy_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatSTT();
        }

        
        private void LamMoiForm()
        {
            dgvChiTietPhieuThanhLy.Rows.Clear();
            dtNgayThanhLy.Value = DateTime.Now;
            LoadDataChiTietThanhLy();
        }


        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            PhieuThanhLySachDTO phieuThanhLySachDTO = new PhieuThanhLySachDTO();
            phieuThanhLySachDTO.MaPhieuthanhLy = txtMaPhieu.Text;
            phieuThanhLySachDTO.MaNV = cbbNhanVien.SelectedValue.ToString();
            phieuThanhLySachDTO.NgayThanhLy = dtNgayThanhLy.Value.ToString("MM-dd-yyyy");

            QuanLyThanhLySachBUS quanLyThanhLySachBUS = new QuanLyThanhLySachBUS();
            quanLyThanhLySachBUS.ThemPhieuThanhLySach(phieuThanhLySachDTO);


            foreach (DataGridViewRow row in dgvChiTietPhieuThanhLy.Rows)
            {
                if (row.Index == dgvChiTietPhieuThanhLy.Rows.Count - 1)
                    break;
                ChiTietPhieuThanhLySachDTO ChiTiet = new ChiTietPhieuThanhLySachDTO();
                ChiTiet.MaPhieuThanhLy = txtMaPhieu.Text;
                ChiTiet.MaSach = row.Cells["MaSach"].Value.ToString();
                ChiTiet.MaLyDoThanhLy = row.Cells["LyDoThanhLy"].Value.ToString();

                quanLyThanhLySachBUS.ThemChiTietPhieuThanhLySach(ChiTiet);
                quanLyThanhLySachBUS.XoaSach(ChiTiet.MaSach);
            }

            MessageBox.Show("Lập phiếu thanh lý sách thành công");
            LoadMaPhieuThanhLy();
            LamMoiForm();
        }

        private void ManHinhChucNangThanhLySach_SizeChanged(object sender, EventArgs e)
        {
            pnWrapperThanhLySach.Location = new Point(this.Width / 2 - pnWrapperThanhLySach.Width / 2, pnWrapperThanhLySach.Location.Y);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrang(0);
        }



        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void cbbNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dtNhanVien.Rows.Count; i++)
            {
                if (cbbNhanVien.SelectedValue.ToString() == dtNhanVien.Rows[i][0].ToString())
                {
                    txtNgaySinh.Text = dtNhanVien.Rows[i]["NgaySinh"].ToString();
                }
            }
        }
    }
}
