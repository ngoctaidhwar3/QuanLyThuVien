
namespace DTO
{
    public class GhiNhanMatSachDTO
    {
        private string _maGNMatSach;
        private string _maSach;
        private int _tienPhat;
        private string _ngayGhiNhan;
        private string _maNV;
        private string _maPT;
        private int _tienNo;
        private string _maDG;
        private string _maPM;

        public string MaGNMatSach
        {
            get { return _maGNMatSach; }
            set { _maGNMatSach = value; }
        }

      
        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
      

        public int TienPhat
        {
            get { return _tienPhat; }
            set { _tienPhat = value; }
        }
       

        public string NgayGhiNhan
        {
            get { return _ngayGhiNhan; }
            set { _ngayGhiNhan = value; }
        }
      

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        

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
       

        public string MaDG
        {
            get { return _maDG; }
            set { _maDG = value; }
        }
       

        public string MaPM
        {
            get { return _maPM; }
            set { _maPM = value; }
        }
    }

    public class SachDocGiaPhieuMuon
    {
        private string _maDG;
        private string _maPM;
        private string _maSach;
        private int _giaTien;
        public string MaDG
        {
            get { return _maDG; }
            set { _maDG = value; }
        }
    

        public string MaPM
        {
            get { return _maPM; }
            set { _maPM = value; }
        }
      

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
       
        public int GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }
        
    }


}
