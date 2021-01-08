using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyThanhLySachBUS
    {
        public DataTable LayThongTinSach(string MaSach)
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                return quanLyThanhLySachDAO.LayThongTinSach(MaSach);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayDanhSachLyDoThanhLy()
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                return quanLyThanhLySachDAO.LayDanhSachLyDoThanhLy();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayThongTinNhanVien(string MaNhanVien)
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                return quanLyThanhLySachDAO.LayThongTinNhanVien(MaNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayMaPhieuLonNhat()
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                DataTable dtMaPhieuThanhLy = quanLyThanhLySachDAO.LayMaPhieuLonNhat();

                string MaPhieuLonNhat = dtMaPhieuThanhLy.Rows[0]["MaPhieuThanhLy"].ToString();
                int num = int.Parse(MaPhieuLonNhat.Substring(4)) + 1;
                string MaMoi = "PTLS" + num.ToString("000");
                return MaMoi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ThemPhieuThanhLySach(PhieuThanhLySachDTO phieuThanhLySach)
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                int Row = quanLyThanhLySachDAO.ThemPhieuThanhLySach(phieuThanhLySach);

                return Row;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ThemChiTietPhieuThanhLySach(ChiTietPhieuThanhLySachDTO phieuChiTietThanhLySach)
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                int Row = quanLyThanhLySachDAO.ThemChiTietPhieuThanhLySach(phieuChiTietThanhLySach);

                return Row;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int XoaSach(string MaSach)
        {
            try
            {
                QuanLyThanhLySachDAO quanLyThanhLySachDAO = new QuanLyThanhLySachDAO();
                int Row = quanLyThanhLySachDAO.XoaSach(MaSach);

                return Row;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ThemQuanLyThanhLySach(string tenQuanLyThanhLySach)
        {
            try
            {
                QuanLyThanhLySachDAO QuanLyThanhLySach = new QuanLyThanhLySachDAO();
                DataTable dsQuanLyThanhLySach = QuanLyThanhLySach.LayDanhSachLyDoThanhLy();
                string maQuanLyThanhLySach = "LDTL" + (int.Parse(dsQuanLyThanhLySach.Rows[dsQuanLyThanhLySach.Rows.Count - 1][0].ToString().Substring(4, 3)) + 1).ToString("000");
                QuanLyThanhLySach.ThemQuanLyThanhLySach(tenQuanLyThanhLySach, maQuanLyThanhLySach);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaQuanLyThanhLySach(string tenQuanLyThanhLySach, string maQuanLyThanhLySach)
        {
            try
            {
                QuanLyThanhLySachDAO QuanLyThanhLySach = new QuanLyThanhLySachDAO();
                QuanLyThanhLySach.SuaQuanLyThanhLySach(tenQuanLyThanhLySach, maQuanLyThanhLySach);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaQuanLyThanhLySach(string maQuanLyThanhLySach)
        {
            try
            {
                QuanLyThanhLySachDAO QuanLyThanhLySach = new QuanLyThanhLySachDAO();
                QuanLyThanhLySach.XoaQuanLyThanhLySach(maQuanLyThanhLySach);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
