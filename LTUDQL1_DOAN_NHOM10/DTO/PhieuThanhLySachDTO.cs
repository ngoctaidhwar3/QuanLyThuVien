
namespace DTO
{
    public class PhieuThanhLySachDTO
    {
        private string _maPhieuthanhLy;
        private string _maNV;
        private string _ngayThanhLy;

        public string MaPhieuthanhLy
        {
            get { return _maPhieuthanhLy; }
            set { _maPhieuthanhLy = value; }
        }
      
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string NgayThanhLy
        {
            get { return _ngayThanhLy; }
            set { _ngayThanhLy = value; }
        }

    }
}
