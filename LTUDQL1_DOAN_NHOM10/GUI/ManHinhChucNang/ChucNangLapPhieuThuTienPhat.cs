using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;
using static GUI.MenuForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangLapPhieuThuTienPhat : UserControl
    {
        PhieuThuTienPhatDTO pttp = new PhieuThuTienPhatDTO();
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangLapPhieuThuTienPhat(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            this.ChuyenTrangChu = ChuyenTrangChu;
        }
        public void LoadData()
        {
            PhieuThuTienPhatBUS bus = new PhieuThuTienPhatBUS();
            dgvDSDocGiaNo.DataSource = bus.LayDSDocGiaNo();
        }



        private void ManHinhChucNangLapPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            
            LoadData();
            if (dgvDSDocGiaNo.Rows.Count > 0)
            {
                txtMaDG.Text = dgvDSDocGiaNo.Rows[0].Cells["MaDG"].Value.ToString();
                txtMaPT.Text = dgvDSDocGiaNo.Rows[0].Cells["MaPT"].Value.ToString();
                txtTienNo.Text = dgvDSDocGiaNo.Rows[0].Cells["TienNo"].Value.ToString();
            }
        }

        private void dgvDSDocGiaNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDG.Text = dgvDSDocGiaNo.SelectedRows[0].Cells["MaDG"].Value.ToString();
                txtMaPT.Text = dgvDSDocGiaNo.SelectedRows[0].Cells["MaPT"].Value.ToString();
                txtTienNo.Text = dgvDSDocGiaNo.SelectedRows[0].Cells["TienNo"].Value.ToString();
            }
        }
        public int KiemTraNhanVien()
        {
            PhieuThuTienPhatBUS bus = new PhieuThuTienPhatBUS();
            DataTable dsNVTQ = bus.DanhSachNhanVienThuQuy();
            int kq = 0;
            List<string> listNV = new List<string>();
            for (int i = 0; i < dsNVTQ.Rows.Count; i++)
            {
                string temp = dsNVTQ.Rows[i]["MaNhanVien"].ToString();
                listNV.Add(temp);
                if (txtNguoiLapPhieu.Text.CompareTo(listNV[i]) == 0)
                {
                    kq = 1;
                }
            }
            return kq;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ck = true;
            ck = int.TryParse(txtTienThu.Text, out int tienThu);
            if (ck == false)
            {
                MessageBox.Show("Số tền thu phải là một chuỗi số!!!");
                return;
            }

            if (txtTienThu.Text == "")
            {
                MessageBox.Show("Cần nhập số tiền thu");
                return;
            }
            PhieuThuTienPhatBUS bus = new PhieuThuTienPhatBUS();
            pttp.MaPT = txtMaPT.Text;

            pttp.TienNo = int.Parse(txtTienNo.Text) - tienThu;




            if (KiemTraNhanVien() == 0)
            {
                MessageBox.Show("Bạn không phải nhân viên thủ quỹ!!");
                return;
            }
            else
            {
                
                DataTable dtPhieuThu = bus.LayMaPhieuthu();
                string maphieuthu = dtPhieuThu.Rows[0][0].ToString();
                
                int num = int.Parse(maphieuthu.Substring(4)) + 1;
                string MaPhieuThu = "PTTP" + num.ToString("000");

                pttp.MaPhieuThu = MaPhieuThu;
                pttp.MaNV = txtNguoiLapPhieu.Text;
                pttp.TienThu = int.Parse(txtTienThu.Text);
                pttp.NgayThu = dtpNgayLap.Value.ToString("MM/dd/yyyy").Substring(0, 10);
                pttp.MaPT = txtMaPT.Text;
                pttp.TienConLai = int.Parse(txtTienNo.Text) - int.Parse(txtTienThu.Text);

                bus.ThemPhieuThuTienPhat(pttp);

                bus.UpDatePhieuTra(pttp);
                MessageBox.Show("Đã thanh toán tiền nợ! Đã thêm vào danh sách phiếu trả");

            }
            LoadData();
        }
        private void txtNguoiLapPhieu_Leave(object sender, EventArgs e)
        {
            if (txtNguoiLapPhieu.Text.Length > 6 || txtNguoiLapPhieu.Text == "" || txtNguoiLapPhieu.Text.Length < 6)
            {
                MessageBox.Show("Cần nhập lại mã nhân viên theo định dạng NVxxxx!!!");
                return;
            }
            string fFormat = txtNguoiLapPhieu.Text.Substring(0, 2);
            string sNum = txtNguoiLapPhieu.Text.Substring(2);
            fFormat = fFormat.ToUpper();
            txtNguoiLapPhieu.Text = fFormat + sNum;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }
    }
}
