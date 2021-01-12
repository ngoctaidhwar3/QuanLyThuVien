using DAO.DocGiaDAO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class TinhTrangDocGiaBUS
    {
        public DataTable LayDanhSachTinhTrangDocGia()
        {
            try
            {
                TinhTrangDocGiaDAO dsNhanVien = new TinhTrangDocGiaDAO();
                DataTable table = dsNhanVien.LayDanhSachTinhTrangDocGia();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemTinhTrangDG(string tenTinhTrangDG)
        {
            try
            {
                TinhTrangDocGiaDAO TinhTrangDG = new TinhTrangDocGiaDAO();
                DataTable dsTinhTrangDG = TinhTrangDG.LayDanhSachTinhTrangDocGia();
                string maTinhTrangDG = "TTDG" + (int.Parse(dsTinhTrangDG.Rows[dsTinhTrangDG.Rows.Count - 1][0].ToString().Substring(4, 2)) + 1).ToString("00");
                TinhTrangDG.ThemTinhTrangDG(tenTinhTrangDG, maTinhTrangDG);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaTinhTrangDG(string tenTinhTrangDG, string maTinhTrangDG)
        {
            try
            {
                TinhTrangDocGiaDAO TinhTrangDG = new TinhTrangDocGiaDAO();
                TinhTrangDG.SuaTinhTrangDG(tenTinhTrangDG, maTinhTrangDG);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaTinhTrangDG(string maTinhTrangDG)
        {
            try
            {
                TinhTrangDocGiaDAO TinhTrangDG = new TinhTrangDocGiaDAO();
                TinhTrangDG.XoaTinhTrangDG(maTinhTrangDG);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
