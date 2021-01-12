using System;

namespace DTO
{
    public class PhieuTraDTO
    {
        string maPT, maPM;

        public string MaPM
        {
            get { return maPM; }
            set { maPM = value; }
        }

        public string MaPT
        {
            get { return maPT; }
            set { maPT = value; }
        }
        DateTime ngayTra;

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        float tienPhatKyNay, tienNo, soNgayTraTre;

        public float SoNgayTraTre
        {
            get { return soNgayTraTre; }
            set { soNgayTraTre = value; }
        }

        public float TienNo
        {
            get { return tienNo; }
            set { tienNo = value; }
        }

        public float TienPhatKyNay
        {
            get { return tienPhatKyNay; }
            set { tienPhatKyNay = value; }
        }

    }
}
