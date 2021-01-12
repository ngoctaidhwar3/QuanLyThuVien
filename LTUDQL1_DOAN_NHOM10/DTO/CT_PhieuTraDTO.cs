using System;

namespace DTO
{
    public class CT_PhieuTraDTO
    {
        string maPT;
        string maSach;
        DateTime ngayMuon;
        int soNgayMuon;
        float tienPhat;

        public string MaPT
        {
            get { return maPT; }
            set { maPT = value; }
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }
        public int SoNgayMuon
        {
            get { return soNgayMuon; }
            set { soNgayMuon = value; }
        }
        public float TienPhat
        {
            get { return tienPhat; }
            set { tienPhat = value; }
        }


    }
}
