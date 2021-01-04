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
using DTO;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangChoMuonSach : UserControl
    {
        HamChuyenTrang ChuyenTrang;
        private int STTSach = 1;
        private string TinhTrangDG = "TTDG01";
        List<string> ListMaSach = new List<string>();
        List<int> ListViTri = new List<int>();
        string MaBiXoa = "";
        int MaxSach = 0;
        int MaxNgayMuon = 0;
        public ManHinhChucNangChoMuonSach(HamChuyenTrang ChuyenTrang)
        {
            InitializeComponent();
            this.ChuyenTrang = ChuyenTrang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ChuyenTrang(0);
        }

        private void ManHinhChucNangChoMuonSach_Load(object sender, EventArgs e)
        {
            LoadMaPhieuMuon();
            QuanLyPhieuMuonBUS BUS = new QuanLyPhieuMuonBUS();
            DataTable dtQuyDinh = BUS.LayQuyDinh();
            MaxSach = int.Parse(dtQuyDinh.Rows[0]["SoSachMuonToiDa"].ToString());
            MaxNgayMuon = int.Parse(dtQuyDinh.Rows[0]["SoNgayMuonToiDa"].ToString());
        }

        void LoadMaPhieuMuon()
        {
            QuanLyPhieuMuonBUS BUS = new QuanLyPhieuMuonBUS();
            DataTable dtMaPM = BUS.LayMaPhieuMuon();
            string ma = dtMaPM.Rows[0]["MaPM"].ToString();
            int lastIndex = int.Parse(ma.Substring(2)) + 1;
            txtMaPhieuMuon.Text = "PM" + lastIndex.ToString("000");
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (STTSach > 1 && txtMaDG.Text != "" && dtgrvPM[1, 0].Value.ToString() != "")
            {
                if (TinhTrangDG.CompareTo("TTDG01") == 0)
                {
                    
                    DateTime ngayMuon = new DateTime(dtNgayMuon.Value.Year, dtNgayMuon.Value.Month, dtNgayMuon.Value.Day);
                    DateTime newTime = ngayMuon.AddDays(MaxNgayMuon);
                    PhieuMuonDTO PhieuMuon = new PhieuMuonDTO();
                    PhieuMuon.MaPM = txtMaPhieuMuon.Text;
                    PhieuMuon.NgayMuon = dtNgayMuon.Value;
                    PhieuMuon.MaDG = txtMaDG.Text;
                    PhieuMuon.NgayHetHan = newTime;
                    QuanLyPhieuMuonBUS BUS = new QuanLyPhieuMuonBUS();
                    int nRow = BUS.ThemPhieuMuon(PhieuMuon);

                   
                    CT_PhieuMuonDTO CTPM;
                    for (int i = 0; i < dtgrvPM.RowCount; i++)
                    {
                        if (Convert.ToString(dtgrvPM.Rows[i].Cells[1].Value) != "")
                        {
                            CTPM = new CT_PhieuMuonDTO();
                            CTPM.MaPM = txtMaPhieuMuon.Text;
                            CTPM.MaSach = Convert.ToString(dtgrvPM.Rows[i].Cells[1].Value);
                            BUS.ThemChiTietPhieuMuon(CTPM);
                            BUS.CapNhatTinhTrangSach(CTPM.MaSach);
                        }
                    }

                    if (nRow > 0)
                    {
                        MessageBox.Show("Lập phiếu mượn thành công", "THÔNG BÁO");
                        LoadThemThanhCong();
                    }
                    else
                    {
                        MessageBox.Show("Lập phiếu mượn thất bại", "THÔNG BÁO");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể mượn sách vì thẻ độc giả đã hết hạn", "THÔNG BÁO");
                    return;
                }
            }
            else if (txtMaDG.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập mã độc giả", "THÔNG BÁO");
                txtMaDG.Focus();
                return;
            }
            else if (STTSach == 1 || dtgrvPM[1, 0].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng thêm sách vào phiếu mượn", "THÔNG BÁO");
            }
        }

        void LoadThemThanhCong()
        {
            LoadMaPhieuMuon();
            txtMaDG.Text = "";
            txtHoTenDG.Text = "";
            txtLoaiDocGia.Text = "";
            txtNgaySinh.Text = "";
            for (int i = 0; i < dtgrvPM.RowCount; i++)
            {
                if (dtgrvPM[1, i].Value != null)
                {
                    dtgrvPM.Rows.RemoveAt(i);
                    i--;
                }
            }
            STTSach = 1;
            ListMaSach.Clear();
            ListViTri.Clear();
        }

        private void dtgrvPM_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrvPM.Rows[e.RowIndex].Cells[1].Value == null)
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    if (e.RowIndex != dtgrvPM.RowCount - 1)
                    {
                        dtgrvPM.Rows.RemoveAt(e.RowIndex);
                        ListMaSach.Remove(MaBiXoa);
                        ListViTri.Remove(e.RowIndex);
                        STTSach--;
                    }
                }));
                return;
            }
            string MaSach = dtgrvPM[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (MaSach != "")
            {
                for (int i = 0; i < ListMaSach.Count; i++)
                {
                    if (MaSach == ListMaSach[i] && e.RowIndex != ListViTri[i])
                    {
                        MessageBox.Show("Cuốn sách này đã có trong phiếu mượn", "THÔNG BÁO");
                        dtgrvPM[e.ColumnIndex, e.RowIndex].Value = null;
                        dtgrvPM[2, e.RowIndex].Value = "";
                        dtgrvPM[3, e.RowIndex].Value = "";
                        dtgrvPM[4, e.RowIndex].Value = "";
                        return;
                    }
                }
                QuanLyPhieuMuonBUS BUS = new QuanLyPhieuMuonBUS();
                DataTable dtSach = BUS.LaySachTrongPhieuMuon(MaSach);
                if (dtSach.Rows.Count > 0)
                {
                    if (dtSach.Rows[0]["TTS"].ToString() != "TTS02")
                    {
                        MessageBox.Show("Cuốn sách này hiện tại không có sẵn", "THÔNG BÁO");
                        dtgrvPM[e.ColumnIndex, e.RowIndex].Value = null;
                        dtgrvPM[2, e.RowIndex].Value = "";
                        dtgrvPM[3, e.RowIndex].Value = "";
                        dtgrvPM[4, e.RowIndex].Value = "";
                        return;
                    }
                    dtgrvPM[2, e.RowIndex].Value = dtSach.Rows[0]["TenSach"];
                    dtgrvPM[3, e.RowIndex].Value = dtSach.Rows[0]["TenTheLoai"];
                    dtgrvPM[4, e.RowIndex].Value = dtSach.Rows[0]["TenTacGia"];
                    ListMaSach.Add(dtgrvPM[1, e.RowIndex].Value.ToString());
                    ListViTri.Add(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cuốn sách nào với mã sách: " + MaSach, "THÔNG BÁO");
                    dtgrvPM[1, e.RowIndex].Value = "";
                    dtgrvPM[2, e.RowIndex].Value = "";
                    dtgrvPM[3, e.RowIndex].Value = "";
                    dtgrvPM[4, e.RowIndex].Value = "";
                }
            }
        }

        private void dtgrvPM_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            STTSach++;
            SapXepSTT();
        }

        private void SapXepSTT()
        {
            for (int i = 0; i < dtgrvPM.RowCount; i++)
            {
                dtgrvPM[0, i].Value = i + 1;
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
                    txtHoTenDG.Text = dtDocGia.Rows[0]["HoTenDG"].ToString();
                    txtNgaySinh.Text = dtDocGia.Rows[0]["NgaySinh"].ToString().Substring(0, 10);
                    txtLoaiDocGia.Text = dtDocGia.Rows[0]["TenLoaiDG"].ToString();
                    TinhTrangDG = dtDocGia.Rows[0]["TTDG"].ToString();
                }
                else
                {
                    MessageBox.Show("Mã độc giả không tồn tại", "THÔNG BÁO");
                    txtMaDG.Text = "";
                    txtHoTenDG.Text = "";
                    txtNgaySinh.Text = "";
                    txtLoaiDocGia.Text = "";
                    txtMaDG.Focus();
                }
            }
        }

        private void dtgrvPM_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SapXepSTT();
        }

        private void dtgrvPM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrvPM[1, e.RowIndex].Value != null)
            {
                MaBiXoa = dtgrvPM[1, e.RowIndex].Value.ToString();
            }
        }

        private void dtgrvPM_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrvPM.Rows != null && dtgrvPM.Rows.Count > MaxSach)
            {
                dtgrvPM.AllowUserToAddRows = false;
            }
            else
            {
                dtgrvPM.AllowUserToAddRows = true;
            }
        }
    }
}
