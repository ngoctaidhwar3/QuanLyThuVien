using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class QuanLyPhieuMuonBUS
    {
        public DataTable LaySachTrongPhieuMuon(string MaSach)
        {
            try
            {
                QuanLyPhieuMuonDAO Dao = new QuanLyPhieuMuonDAO();
                return Dao.LaySachTrongPhieuMuon(MaSach);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable LayDocGia(string MaDG)
        {
            try
            {
                QuanLyPhieuMuonDAO Dao = new QuanLyPhieuMuonDAO();
                return Dao.LayDocGia(MaDG);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable LayQuyDinh()
        {
            try
            {
                QuanLyPhieuMuonDAO Dao = new QuanLyPhieuMuonDAO();
                return Dao.LayQuyDinh();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable LayMaPhieuMuon()
        {
            try
            {
                QuanLyPhieuMuonDAO Dao = new QuanLyPhieuMuonDAO();
                return Dao.LayMaPhieuMuon();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemPhieuMuon(PhieuMuonDTO PM)
        {
            try
            {
                QuanLyPhieuMuonDAO DAO = new QuanLyPhieuMuonDAO();
                return DAO.ThemPhieuMuon(PM);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemChiTietPhieuMuon(CT_PhieuMuonDTO CTPM)
        {
            try
            {
                QuanLyPhieuMuonDAO DAO = new QuanLyPhieuMuonDAO();
                return DAO.ThemChiTietPhieuMuon(CTPM);
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
                QuanLyPhieuMuonDAO DAO = new QuanLyPhieuMuonDAO();
                return DAO.CapNhatTinhTrangSach(MaSach);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
