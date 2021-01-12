using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class QuanLyPhieuTraBUS
    {
        public DataTable LayMaPhieuTra()
        {
            try
            {
                QuanLyPhieuTraDAO DAO = new QuanLyPhieuTraDAO();
                return DAO.LayMaPhieuTra();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable KiemTraDocGiaCoPhieuMuon(string MaDG)
        {
            try
            {
                QuanLyPhieuTraDAO DAO = new QuanLyPhieuTraDAO();
                return DAO.KiemTraDocGiaCoPhieuMuon(MaDG);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable KiemTraSachCoTrongPhieuMuon(string MaDG, string MaSach)
        {
            try
            {
                QuanLyPhieuTraDAO DAO = new QuanLyPhieuTraDAO();
                return DAO.KiemTraSachCoTrongPhieuMuon(MaDG, MaSach);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemPhieuTra(PhieuTraDTO PT)
        {
            try
            {
                QuanLyPhieuTraDAO DAO = new QuanLyPhieuTraDAO();
                return DAO.ThemPhieuTra(PT);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemChiTietPhieuTra(CT_PhieuTraDTO CTPT)
        {
            try
            {
                QuanLyPhieuTraDAO DAO = new QuanLyPhieuTraDAO();
                return DAO.ThemChiTietPhieuTra(CTPT);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhatTinhTrangSach(string MaSach)
        {
            try
            {
                QuanLyPhieuTraDAO DAO = new QuanLyPhieuTraDAO();
                return DAO.CapNhatTinhTrangSach(MaSach);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
