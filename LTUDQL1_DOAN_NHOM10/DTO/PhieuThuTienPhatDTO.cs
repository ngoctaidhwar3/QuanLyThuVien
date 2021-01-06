using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTienPhatDTO
    {
        private string _maPT;
        private int _tienNo;
        private string _maNV;
        private string _maPhieuThu;
        private int _tienThu;
        private string _ngayThu;
        private int _tienConLai;

        public string MaPT
        {
            get { return _maPT; }
            set { _maPT = value; }
        }

        public int TienNo
        {
            get { return _tienNo; }
            set { _tienNo = value; }
        }

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string MaPhieuThu
        {
            get { return _maPhieuThu; }
            set { _maPhieuThu = value; }
        }

        public int TienThu
        {
            get { return _tienThu; }
            set { _tienThu = value; }
        }

        public string NgayThu
        {
            get { return _ngayThu; }
            set { _ngayThu = value; }
        }

        public int TienConLai
        {
            get { return _tienConLai; }
            set { _tienConLai = value; }

        }
    }
}
