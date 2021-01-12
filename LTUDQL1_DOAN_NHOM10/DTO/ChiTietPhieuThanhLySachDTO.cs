
namespace DTO
{
    public class ChiTietPhieuThanhLySachDTO
    {
        private string _maPhieuThanhLy;
        private string _maSach;
        private string _maLyDoThanhLy;

        public string MaPhieuThanhLy
        {
            get { return _maPhieuThanhLy; }
            set { _maPhieuThanhLy = value; }
        }
        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        public string MaLyDoThanhLy
        {
            get { return _maLyDoThanhLy; }
            set { _maLyDoThanhLy = value; }
        }

    }
}
