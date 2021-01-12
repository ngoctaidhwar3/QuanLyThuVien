using DAO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class ChucVuBUS
    {
        public DataTable LayDanhSachChucVu()
        {
            try
            {
                ChucVuDAO dsChucVu = new ChucVuDAO();
                DataTable table = dsChucVu.LayDanhSachChucVu();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemChucVu(string tenChucVu)
        {
            try
            {
                ChucVuDAO ChucVu = new ChucVuDAO();
                DataTable dsChucVu = ChucVu.LayDanhSachChucVu();
                string maChucVu = "CV" + (int.Parse(dsChucVu.Rows[dsChucVu.Rows.Count - 1][0].ToString().Substring(2, 2)) + 1).ToString("00");
                ChucVu.ThemChucVu(tenChucVu, maChucVu);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaChucVu(string tenChucVu, string maChucVu)
        {
            try
            {
                ChucVuDAO ChucVu = new ChucVuDAO();
                ChucVu.SuaChucVu(tenChucVu, maChucVu);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaChucVu(string maChucVu)
        {
            try
            {
                ChucVuDAO ChucVu = new ChucVuDAO();
                ChucVu.XoaChucVu(maChucVu);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
