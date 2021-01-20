using DAO.DocGiaDAO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class LoaiDocGiaBUS
    {
        public DataTable LayDanhSachLoaiDocGia()
        {
            try
            {
                LoaiDocGiaDAO dsDocGia = new LoaiDocGiaDAO();
                DataTable table = dsDocGia.LayDanhSachLoaiDocGia();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemLoaiDocGia(string tenLoaiDocGia)
        {
            try
            {
                LoaiDocGiaDAO LoaiDocGia = new LoaiDocGiaDAO();
                DataTable dsLoaiDocGia = LoaiDocGia.LayDanhSachLoaiDocGia();
                string maLoaiDocGia = "LDG" + (int.Parse(dsLoaiDocGia.Rows[dsLoaiDocGia.Rows.Count - 1][0].ToString().Substring(3, 1)) + 1).ToString("0");
                LoaiDocGia.ThemLoaiDocGia(tenLoaiDocGia, maLoaiDocGia);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaLoaiDocGia(string tenLoaiDocGia, string maLoaiDocGia)
        {
            try
            {
                LoaiDocGiaDAO LoaiDocGia = new LoaiDocGiaDAO();
                LoaiDocGia.SuaLoaiDocGia(tenLoaiDocGia, maLoaiDocGia);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaLoaiDocGia(string maLoaiDocGia)
        {
            try
            {
                LoaiDocGiaDAO LoaiDocGia = new LoaiDocGiaDAO();
                LoaiDocGia.XoaLoaiDocGia(maLoaiDocGia);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
