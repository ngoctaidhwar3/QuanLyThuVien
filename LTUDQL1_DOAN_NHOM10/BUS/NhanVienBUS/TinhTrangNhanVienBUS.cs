using DAO;
using System;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class TinhTrangNhanVienBUS
    {
        public DataTable LayDanhSachTinhTrangNhanVien()
        {
            try
            {
                TinhTrangNhanVienDAO dsNhanVien = new TinhTrangNhanVienDAO();
                DataTable table = dsNhanVien.LayDanhSachTinhTrangNhanVien();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemTinhTrang(string tenTinhTrang)
        {
            try
            {
                TinhTrangNhanVienDAO TinhTrang = new TinhTrangNhanVienDAO();
                DataTable dsTinhTrang = TinhTrang.LayDanhSachTinhTrangNhanVien();
                string maTinhTrang = "TTNV" + (int.Parse(dsTinhTrang.Rows[dsTinhTrang.Rows.Count - 1][0].ToString().Substring(4, 2)) + 1).ToString("00");
                TinhTrang.ThemTinhTrang(tenTinhTrang, maTinhTrang);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaTinhTrang(string tenTinhTrang, string maTinhTrang)
        {
            try
            {
                TinhTrangNhanVienDAO TinhTrang = new TinhTrangNhanVienDAO();
                TinhTrang.SuaTinhTrang(tenTinhTrang, maTinhTrang);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaTinhTrang(string maTinhTrang)
        {
            try
            {
                TinhTrangNhanVienDAO TinhTrang = new TinhTrangNhanVienDAO();
                TinhTrang.XoaTinhTrang(maTinhTrang);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
