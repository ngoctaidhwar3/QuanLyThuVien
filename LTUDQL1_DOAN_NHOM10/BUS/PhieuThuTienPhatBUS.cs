using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class PhieuThuTienPhatBUS
    {
        public DataTable LayDSDocGiaNo()
        {
            try
            {
                PhieuThuTienPhatDAO dao = new PhieuThuTienPhatDAO();
                return dao.LayDSDocGiaNo();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpDatePhieuTra(PhieuThuTienPhatDTO pttp)
        {
            try
            {
                PhieuThuTienPhatDAO dao = new PhieuThuTienPhatDAO();
                int nRow = dao.UpDatePhieuTra(pttp);
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayMaPhieuthu()
        {
            try
            {
                PhieuThuTienPhatDAO dao = new PhieuThuTienPhatDAO();
                return dao.LayMaPhieuThu();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemPhieuThuTienPhat(PhieuThuTienPhatDTO pttp)
        {
            try
            {
                PhieuThuTienPhatDAO dao = new PhieuThuTienPhatDAO();
                return dao.ThemPhieuThuTienPhat(pttp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable DanhSachNhanVienThuQuy()
        {
            try
            {
                PhieuThuTienPhatDAO dao = new PhieuThuTienPhatDAO();
                return dao.DanhSachNhanVienThuQuy();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
