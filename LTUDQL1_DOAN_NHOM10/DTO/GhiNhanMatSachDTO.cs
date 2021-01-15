
namespace DTO
{
    public class GhiNhanMatSachDTO
    {
        private string _maGNMatSach { get; set; }
        private string _maSach { get; set; }
        private int _tienPhat { get; set; }
        private string _ngayGhiNhan { get; set; }
        private string _maNV { get; set; }
        private string _maPT { get; set; }
        private int _tienNo { get; set; }
        private string _maDG { get; set; }
        private string _maPM { get; set; }



        public class SachDocGiaPhieuMuon
        {
            private string _maDG { get; set; }
            private string _maPM { get; set; }
            private string _maSach { get; set; }
            private int _giaTien { get; set; }
        }
    }
}
