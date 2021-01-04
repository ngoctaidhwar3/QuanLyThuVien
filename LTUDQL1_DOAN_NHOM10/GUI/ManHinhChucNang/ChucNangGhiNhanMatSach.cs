using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using static GUI.ManHinhThucDonForm;

namespace GUI.ManHinhChucNang
{
    public partial class ManHinhChucNangGhiNhanMatSach : UserControl
    {
        GhiNhanMatSachDTO gnms = new GhiNhanMatSachDTO();
        GhiNhanMatSachBUS bus = new GhiNhanMatSachBUS();

        List<SachDocGiaPhieuMuon> listDG = new List<SachDocGiaPhieuMuon>();
        SachDocGiaPhieuMuon pmdocgia = new SachDocGiaPhieuMuon();
        HamChuyenTrang ChuyenTrangChu;
        public ManHinhChucNangGhiNhanMatSach(HamChuyenTrang ChuyenTrangChu)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = bus.SachDocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SachDocGiaPhieuMuon temp = new SachDocGiaPhieuMuon();
                temp.MaDG = dt.Rows[i]["MaDG"].ToString();
                temp.MaPM = dt.Rows[i]["MaPM"].ToString();
                temp.MaSach = dt.Rows[i]["MaSach"].ToString();
                temp.GiaTien = int.Parse(dt.Rows[i]["GiaTien"].ToString());
                listDG.Add(temp);
            }

            this.ChuyenTrangChu = ChuyenTrangChu;
        }

        private void txtMaSach_Leave(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
                return;
            if (txtMaSach.Text.Length != 4)
            {
                MessageBox.Show("Cần nhập lại mã sách theo định dạng Sxxx!!!");
                return;
            }
            string fFormat = txtMaSach.Text.Substring(0, 1);
            string sNum = txtMaSach.Text.Substring(1);
            fFormat = fFormat.ToUpper();
            txtMaSach.Text = fFormat + sNum;
        }

        private void txtMaDG_Leave(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "")
                return;
            if (txtMaDG.Text.Length != 6)
            {
                MessageBox.Show("Cần nhập lại mã độc giả theo định dạng DGxxxx!!!");
                return;
            }

            string fFormat = txtMaDG.Text.Substring(0, 2);
            string sNum = txtMaDG.Text.Substring(2);
            fFormat = fFormat.ToUpper();
            txtMaDG.Text = fFormat + sNum;
        }

        private void txtTienPhat_Leave(object sender, EventArgs e)
        {
            if (txtTienPhat.Text == "")
                return;
            else if (int.TryParse(txtTienPhat.Text, out int tienphat))
            {
                gnms.TienPhat = tienphat;
            }
            else
            {
                MessageBox.Show("Tiền phạt nhập vào phải là một chuỗi số nguyên!!");
            }
        }

        private void txtNguoiGhiNhan_Leave(object sender, EventArgs e)
        {
            if (txtNguoiGhiNhan.Text == "")
                return;
            if (txtNguoiGhiNhan.Text.Length != 6)
            {
                MessageBox.Show("Cần nhập lại mã độc giả theo định dạng DGxxxx!!!");
                return;
            }

            string fFormat = txtNguoiGhiNhan.Text.Substring(0, 2);
            string sNum = txtNguoiGhiNhan.Text.Substring(2);
            fFormat = fFormat.ToUpper();
            txtNguoiGhiNhan.Text = fFormat + sNum;
        }
       

        public int KiemTraNhanVienThuThu()
        {
            int kq = 0;

            DataTable dsNVTT = bus.DanhSachNhanVienThuThu();
            List<string> listNV = new List<string>();
            for (int i = 0; i < dsNVTT.Rows.Count; i++)
            {
                string temp = dsNVTT.Rows[i]["MaNhanVien"].ToString();
                listNV.Add(temp);
                if (txtNguoiGhiNhan.Text.CompareTo(listNV[i]) == 0)
                {
                    kq = 1;
                }
            }
            return kq;
        }
        
        public int KiemTraThongtin(string maSach)
        {
            int kq = 0;
            for (int i = 0; i < listDG.Count; i++)
            {
                if (maSach.CompareTo(listDG[i].MaSach) == 0)
                {
                    if (listDG[i].MaDG.CompareTo(txtMaDG.Text) == 1)
                    {
                        kq = 1;
                    }
                    if (listDG[i].GiaTien > int.Parse(txtTienPhat.Text))
                    {
                        kq = 2;
                    }
                    break;
                }
                else
                    kq = 4;
            }
            return kq;
        }
        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (txtTienPhat.Text == "" || txtMaSach.Text == "" || txtMaDG.Text == "" || txtNguoiGhiNhan.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin trên!!!");
                return;
            }
            int kq = KiemTraThongtin(txtMaSach.Text);
            if (kq == 1)
            {
                MessageBox.Show("độc giả này chưa mượn sách" + txtMaSach.Text);
                return;
            }
            else if (kq == 2)
            {
                MessageBox.Show("Tiền phạt phải lớn giá trị cuốn sách!!" + txtTienPhat.Text);
            }
            else if (KiemTraNhanVienThuThu() == 0)
            {
                MessageBox.Show("bạn không phải nhân viên thủ thư");
                return;
            }
            else
            {
                
                DataTable dtGhiNhan = bus.MaGhiNhanSachMat();
                string MaGN = dtGhiNhan.Rows[0]["MaGNMatSach"].ToString();
                
                int num = int.Parse(MaGN.Substring(2)) + 1;
                string MaGNMatSach = "SM" + num.ToString("000");
                
                gnms.MaGNMatSach = MaGNMatSach;
                gnms.MaSach = txtMaSach.Text;
                gnms.MaDG = txtMaDG.Text;
                gnms.NgayGhiNhan = dtpNgayGhiNhanMat.Value.ToString("MM/dd/yyyy").Substring(0, 10);
                gnms.MaNV = txtNguoiGhiNhan.Text;
                gnms.TienPhat = int.Parse(txtTienPhat.Text);
                try
                {
                    bus.ThemSachMat(gnms);
                    MessageBox.Show("Đã ghi nhận!!!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.ChuyenTrangChu(0);
        }
    }
}
