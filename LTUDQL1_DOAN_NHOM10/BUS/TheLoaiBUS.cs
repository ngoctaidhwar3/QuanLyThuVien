using DAO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class TheLoaiBUS
    {
        public DataTable LayDanhSachTheLoai()
        {
            try
            {
                TheLoaiDAO dsTheLoai = new TheLoaiDAO();
                DataTable table = dsTheLoai.LayDanhSachTheLoai();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemTheLoai(string tenTheLoai)
        {
            try
            {
                TheLoaiDAO TheLoai = new TheLoaiDAO();
                DataTable dsTheLoai = TheLoai.LayDanhSachTheLoai();
                string maTheLoai = "TLS" + (int.Parse(dsTheLoai.Rows[dsTheLoai.Rows.Count - 1][0].ToString().Substring(3, 3)) + 1).ToString("000");
                TheLoai.ThemTheLoai(maTheLoai, tenTheLoai);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaTheLoai(string maTheLoai, string TenTheLoai)
        {
            try
            {
                TheLoaiDAO TheLoai = new TheLoaiDAO();
                TheLoai.SuaTheLoai(maTheLoai, TenTheLoai);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaTheLoai(string maTheLoai)
        {
            try
            {
                TheLoaiDAO TheLoai = new TheLoaiDAO();
                TheLoai.XoaTheLoai(maTheLoai);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
