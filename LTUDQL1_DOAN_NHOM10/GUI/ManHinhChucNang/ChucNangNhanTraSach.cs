using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BUS;
using BUS.DocGiaBUS;
using DTO;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangNhanTraSach : UserControl
    {
        HamChuyenTrang ChuyenTrang;
        int STTSach = 1;
        List<string> ListMaSach = new List<string>();
        List<int> ListViTri = new List<int>();
        string MaBiXoa = "";
        int soNgayMuonQuyDinh = 0;
        float SoTienPhatQuyDinh = 0;
        string MaPM = "";
        int SoNgayTraTre = 0;
        public ManHinhChucNangNhanTraSach(HamChuyenTrang ChuyenTrang)
        {
            InitializeComponent();
            this.ChuyenTrang = ChuyenTrang;
        }

        private void ManHinhChucNangNhanTraSach_Load(object sender, EventArgs e)
        {
            LoadMaPhieuTra();
            txtMaDG.Focus();
            QuanLyPhieuMuonBUS BUSPM = new QuanLyPhieuMuonBUS();
            DataTable dtQuyDinh = BUSPM.LayQuyDinh();
            txtMaDG.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaDG.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            DataTable dtDsDG = LoadDsDG();
            collection= LoadSuggestTextBox(dtDsDG);
            txtMaDG.AutoCompleteCustomSource = collection;
            soNgayMuonQuyDinh = int.Parse(dtQuyDinh.Rows[0]["SoNgayMuonToiDa"].ToString());
            SoTienPhatQuyDinh = float.Parse(dtQuyDinh.Rows[0]["TienPhatTraTre"].ToString());
            dtgrPhieuTra.Enabled = false;
        }
        AutoCompleteStringCollection LoadSuggestTextBox(DataTable dt)
        {
            string[] str = new string[dt.DefaultView.Count-1];
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.DefaultView.Count-1; i++)
            {
                str[i]=dt.Rows[i]["MaDocGia"].ToString();
            }
            autoComplete.AddRange(str);
            return autoComplete;
        }
        DataTable LoadDsDG()
        {
            int rs = 0;
            DocGiaBUS bus = new DocGiaBUS();
            return bus.LayDanhSachDocGia(rs);
        }
        void LoadMaPhieuTra()
        {
            QuanLyPhieuTraBUS BUS = new QuanLyPhieuTraBUS();
            DataTable dtMaPT = BUS.LayMaPhieuTra();
            string ma = dtMaPT.Rows[dtMaPT.DefaultView.Count-1]["MaPT"].ToString();
            int lastIndex = int.Parse(ma.Substring(2)) + 1;
            txtMaPhieuTra.Text = "PT" + lastIndex.ToString("000");
        }

        private void dtgrPhieuTra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtMaDG.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập mã độc giả", "THÔNG BÁO");
                txtMaDG.Focus();
            }
            if (dtgrPhieuTra[1, e.RowIndex].Value != null)
            {
                MaBiXoa = dtgrPhieuTra[1, e.RowIndex].Value.ToString();
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text != "" && STTSach > 1 && dtgrPhieuTra[1, 0].Value.ToString() != "")
            {
                if (KiemTraNgayTraHopLe() == false)
                {
                    MessageBox.Show("Trong phiếu có sách không hợp lệ với ngày trả xin vui lòng kiểm tra lại", "THÔNG BÁO");
                }
                else
                {
                    PhieuTraDTO PhieuTraDTO = new PhieuTraDTO();
                    PhieuTraDTO.MaPT = txtMaPhieuTra.Text;
                    PhieuTraDTO.NgayTra = dtNgayTra.Value;
                    PhieuTraDTO.MaPM = MaPM;
                    PhieuTraDTO.TienPhatKyNay = float.Parse(txtTienPhatKyNay.Text);
                    PhieuTraDTO.TienNo = float.Parse(txtTongNo.Text);
                    PhieuTraDTO.SoNgayTraTre = SoNgayTraTre;

                    
                    QuanLyPhieuTraBUS BUS = new QuanLyPhieuTraBUS();
                    int nRow = BUS.ThemPhieuTra(PhieuTraDTO);
                    
                    CT_PhieuTraDTO CTPT;
                    for (int i = 0; i < dtgrPhieuTra.RowCount; i++)
                    {
                        if (Convert.ToString(dtgrPhieuTra.Rows[i].Cells[1].Value) != "")
                        {
                            CTPT = new CT_PhieuTraDTO();
                            CTPT.MaPT = txtMaPhieuTra.Text;
                            CTPT.MaSach = Convert.ToString(dtgrPhieuTra.Rows[i].Cells[1].Value);
                            CTPT.NgayMuon = Convert.ToDateTime(dtgrPhieuTra.Rows[i].Cells[2].Value);
                            CTPT.SoNgayMuon = int.Parse(dtgrPhieuTra.Rows[i].Cells[3].Value.ToString());
                            CTPT.TienPhat = float.Parse(dtgrPhieuTra.Rows[i].Cells[4].Value.ToString());
                            BUS.ThemChiTietPhieuTra(CTPT);

                            
                            BUS.CapNhatTinhTrangSach(CTPT.MaSach);
                        }
                    }
                    if (nRow > 0)
                    {
                        MessageBox.Show("Lập phiếu trả thành công", "THÔNG BÁO");
                        LoadThemThanhCong();
                    }
                    else
                    {
                        MessageBox.Show("Lập phiếu trả thất bại", "THÔNG BÁO");
                    }

                }
            }
            else if (txtMaDG.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập mã độc giả", "THÔNG BÁO");
                txtMaDG.Focus();
                return;
            }
            else if (STTSach == 1 || dtgrPhieuTra[1, 0].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng thêm sách vào phiếu trả", "THÔNG BÁO");
            }
        }

        private void txtMaDG_Leave(object sender, EventArgs e)
        {
            if (txtMaDG.Text != "")
            {
                QuanLyPhieuMuonBUS BUS = new QuanLyPhieuMuonBUS();
                DataTable dtDocGia = BUS.LayDocGia(txtMaDG.Text);
                if (dtDocGia.Rows.Count > 0)
                {
                    
                    QuanLyPhieuTraBUS BUSPT = new QuanLyPhieuTraBUS();
                    DataTable dtKiemTra = BUSPT.KiemTraDocGiaCoPhieuMuon(txtMaDG.Text);
                    if (int.Parse(dtKiemTra.Rows[0]["TonTai"].ToString()) > 0)
                    {
                        txtHoTenDG.Text = dtDocGia.Rows[0]["HoTenDG"].ToString();
                        txtNgaySinhDG.Text = dtDocGia.Rows[0]["NgaySinh"].ToString().Substring(0, 10);
                        txtLoaiDG.Text = dtDocGia.Rows[0]["TenLoaiDG"].ToString();
                        txtTienNo.Text = dtDocGia.Rows[0]["TongNo"].ToString();
                        txtTongNo.Text = txtTienNo.Text;
                        dtgrPhieuTra.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Độc giả này không có phiếu mượn sách xin vui lòng kiểm tra lại", "THÔNG BÁO");
                        txtMaDG.Text = "";
                        txtHoTenDG.Text = "";
                        txtNgaySinhDG.Text = "";
                        txtLoaiDG.Text = "";
                        txtTienNo.Text = "";
                        txtTongNo.Text = "";
                        txtMaDG.Focus();
                        dtgrPhieuTra.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Mã độc giả không tồn tại", "THÔNG BÁO");
                    txtMaDG.Text = "";
                    txtHoTenDG.Text = "";
                    txtNgaySinhDG.Text = "";
                    txtLoaiDG.Text = "";
                    txtTienNo.Text = "";
                    txtTongNo.Text = "";
                    txtMaDG.Focus();
                    dtgrPhieuTra.Enabled = false;
                }
            }
        }

        void LoadThemThanhCong()
        {
            LoadMaPhieuTra();
            txtMaDG.Text = "";
            txtHoTenDG.Text = "";
            txtLoaiDG.Text = "";
            txtNgaySinhDG.Text = "";
            txtTienNo.Text = "0";
            txtTienPhatKyNay.Text = "0";
            txtTongNo.Text = "0";
            for (int i = 0; i < dtgrPhieuTra.RowCount; i++)
            {
                if (dtgrPhieuTra[1, i].Value != null)
                {
                    dtgrPhieuTra.Rows.RemoveAt(i);
                    i--;
                }
            }
            STTSach = 1;
            ListMaSach.Clear();
            ListViTri.Clear();
            dtgrPhieuTra.Enabled = false;
        }

        private void dtgrPhieuTra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrPhieuTra.Rows[e.RowIndex].Cells[1].Value == null)
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    if (e.RowIndex != dtgrPhieuTra.RowCount - 1)
                    {
                        if (dtgrPhieuTra[4, e.RowIndex].Value != null)
                        {
                            txtTienPhatKyNay.Text = (float.Parse(txtTienPhatKyNay.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                            txtTongNo.Text = (float.Parse(txtTongNo.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                        }
                        dtgrPhieuTra.Rows.RemoveAt(e.RowIndex);
                        ListMaSach.Remove(MaBiXoa);
                        ListViTri.Remove(e.RowIndex);
                        STTSach--;
                    }
                }));
                return;
            }
            string MaSach = dtgrPhieuTra[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (MaSach != "")
            {
                for (int i = 0; i < ListMaSach.Count; i++)
                {
                    if (MaSach.ToLower() == ListMaSach[i].ToLower() && e.RowIndex != ListViTri[i])
                    {
                        MessageBox.Show("Cuốn sách này đã có trong phiếu trả", "THÔNG BÁO");
                        dtgrPhieuTra[1, e.RowIndex].Value = null;
                        dtgrPhieuTra[2, e.RowIndex].Value = "";
                        dtgrPhieuTra[3, e.RowIndex].Value = "";
                        if (dtgrPhieuTra[4, e.RowIndex].Value != null)
                        {
                            txtTienPhatKyNay.Text = (float.Parse(txtTienPhatKyNay.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                            txtTongNo.Text = (float.Parse(txtTongNo.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                        }
                        dtgrPhieuTra[4, e.RowIndex].Value = null;
                        return;
                    }
                }
                for (int i = 0; i < ListMaSach.Count; i++)
                {
                    if (dtgrPhieuTra[1, e.RowIndex].Value != null)
                    {
                        if (dtgrPhieuTra[1, e.RowIndex].Value.ToString() == ListMaSach[i])
                        {
                            return;
                        }
                    }
                }
                QuanLyPhieuMuonBUS BUS = new QuanLyPhieuMuonBUS();
                DataTable dtSach = BUS.LaySachTrongPhieuMuon(MaSach);
                if (dtSach.Rows.Count > 0)
                {
                    QuanLyPhieuTraBUS BUSPT = new QuanLyPhieuTraBUS();
                    DataTable dtKiemTra = BUSPT.KiemTraSachCoTrongPhieuMuon(txtMaDG.Text, MaSach);
                    if (dtKiemTra.Rows.Count > 0 && int.Parse(dtKiemTra.Rows[0]["TonTai"].ToString()) > 0)
                    {
                        dtgrPhieuTra[2, e.RowIndex].Value = dtKiemTra.Rows[0]["NgayMuon"].ToString().Substring(0, 10);
                        MaPM = dtKiemTra.Rows[0]["MaPM"].ToString();
                        
                        if (KiemTraNgayTraHopLe() == false)
                        {
                            MessageBox.Show("Ngày trả sách không hợp lệ xin vui lòng kiểm tra lại", "THÔNG BÁO");
                        }
                        
                        DateTime ngaymuon = Convert.ToDateTime(dtKiemTra.Rows[0]["NgayMuon"].ToString().Substring(0, 10));
                        DateTime ngaytra = Convert.ToDateTime(dtNgayTra.Value.ToString());
                        TimeSpan Time = ngaytra - ngaymuon;
                        int TongSoNgay = Time.Days + 1;
                        dtgrPhieuTra[3, e.RowIndex].Value = TongSoNgay.ToString();
                        if (TongSoNgay > soNgayMuonQuyDinh)
                        {
                            float TienPhat = (TongSoNgay - soNgayMuonQuyDinh) * SoTienPhatQuyDinh;
                            dtgrPhieuTra[4, e.RowIndex].Value = TienPhat.ToString();
                            txtTienPhatKyNay.Text = (float.Parse(txtTienPhatKyNay.Text) + TienPhat).ToString();
                            txtTongNo.Text = (float.Parse(txtTongNo.Text) + TienPhat).ToString();
                            SoNgayTraTre = TongSoNgay - soNgayMuonQuyDinh;
                        }
                        else
                        {
                            dtgrPhieuTra[4, e.RowIndex].Value = "0";
                        }
                        ListMaSach.Add(dtgrPhieuTra[1, e.RowIndex].Value.ToString());
                        ListViTri.Add(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Cuốn sách này không có trong phiếu mượn", "THÔNG BÁO");
                        if (dtgrPhieuTra[4, e.RowIndex].Value != null)
                        {
                            txtTienPhatKyNay.Text = (float.Parse(txtTienPhatKyNay.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                            txtTongNo.Text = (float.Parse(txtTongNo.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                        }
                        dtgrPhieuTra[1, e.RowIndex].Value = "";
                        dtgrPhieuTra[1, e.RowIndex].Value = null;
                        dtgrPhieuTra[2, e.RowIndex].Value = "";
                        dtgrPhieuTra[3, e.RowIndex].Value = "";
                        dtgrPhieuTra[4, e.RowIndex].Value = null;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cuốn sách nào với mã sách: " + MaSach, "THÔNG BÁO");
                    if (dtgrPhieuTra[4, e.RowIndex].Value != null)
                    {
                        txtTienPhatKyNay.Text = (float.Parse(txtTienPhatKyNay.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                        txtTongNo.Text = (float.Parse(txtTongNo.Text) - float.Parse(dtgrPhieuTra[4, e.RowIndex].Value.ToString())).ToString();
                    }
                    dtgrPhieuTra[1, e.RowIndex].Value = null;
                    dtgrPhieuTra[2, e.RowIndex].Value = "";
                    dtgrPhieuTra[3, e.RowIndex].Value = "";
                    dtgrPhieuTra[4, e.RowIndex].Value = null;
                }
            }
        }

        private void SapXepSTT()
        {
            for (int i = 0; i < dtgrPhieuTra.RowCount; i++)
            {
                dtgrPhieuTra[0, i].Value = i + 1;
            }
        }

        private void dtgrPhieuTra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            STTSach++;
            SapXepSTT();
        }

        private void dtgrPhieuTra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SapXepSTT();
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (KiemTraNgayTraHopLe() == false)
            {
                MessageBox.Show("Ngày trả sách không hợp lệ xin vui lòng kiểm tra lại", "THÔNG BÁO");
            }
            else
            {
                txtTienPhatKyNay.Text = "0";
                txtTongNo.Text = txtTienNo.Text;
                for (int i = 0; i < dtgrPhieuTra.RowCount; i++)
                {
                    if (Convert.ToString(dtgrPhieuTra.Rows[i].Cells[1].Value) != "")
                    {
                        DateTime ngaymuon = Convert.ToDateTime(dtgrPhieuTra[2, i].Value.ToString());
                        DateTime ngaytra = Convert.ToDateTime(dtNgayTra.Value.ToString());
                        TimeSpan Time = ngaytra - ngaymuon;
                        int TongSoNgay = Time.Days + 1;
                        dtgrPhieuTra[3, i].Value = TongSoNgay.ToString();
                        if (TongSoNgay > soNgayMuonQuyDinh)
                        {
                            float TienPhat = (TongSoNgay - soNgayMuonQuyDinh) * SoTienPhatQuyDinh;
                            dtgrPhieuTra[4, i].Value = TienPhat.ToString();
                            txtTienPhatKyNay.Text = (float.Parse(txtTienPhatKyNay.Text) + TienPhat).ToString();
                            txtTongNo.Text = (float.Parse(txtTongNo.Text) + TienPhat).ToString();
                        }
                        else
                        {
                            dtgrPhieuTra[4, i].Value = "0";
                        }
                    }
                }

            }
        }

        bool KiemTraNgayTraHopLe()
        {
            for (int i = 0; i < dtgrPhieuTra.RowCount; i++)
            {
                if (Convert.ToString(dtgrPhieuTra.Rows[i].Cells[1].Value) != "")
                {
                    DateTime ngaymuon = Convert.ToDateTime(dtgrPhieuTra[2, i].Value.ToString());
                    DateTime ngaytra = Convert.ToDateTime(dtNgayTra.Value.ToString());
                    TimeSpan Time = ngaytra - ngaymuon;
                    int TongSoNgay = Time.Days;
                    string SNgayMuon = Convert.ToDateTime(dtgrPhieuTra[2, i].Value.ToString()).ToString().Substring(0, 10);
                    string SngayTra = Convert.ToDateTime(dtNgayTra.Value.ToString()).ToString().Substring(0, 10);
                    if (TongSoNgay <= 0 && SNgayMuon != SngayTra)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrang(0);
        }

    }
}
