using DAO;
using System;
using System.Data;

namespace BUS
{
    public class TacGiaBUS
    {
        public DataTable LayDanhSachTacGia()
        {
            try
            {
                TacGiaDAO TacGiaDAO = new TacGiaDAO();
                return TacGiaDAO.LayDanhSachTacGia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThemTacGia(string tenTacGia)
        {
            try
            {
                TacGiaDAO TacGiaDAO = new TacGiaDAO();
                DataTable dsTacGia = TacGiaDAO.LayDanhSachTacGia();
                string maTacGia = "TG" + (int.Parse(dsTacGia.Rows[dsTacGia.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1).ToString("000");
                TacGiaDAO.ThemTacGia(maTacGia, tenTacGia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SuaTacGia(string maTacGia, string tenTacGia)
        {
            try
            {
                TacGiaDAO TacGiaDAO = new TacGiaDAO();
                TacGiaDAO.SuaTacGia(maTacGia, tenTacGia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaTacGia(string maTacGia)
        {
            try
            {
                TacGiaDAO TacGiaDAO = new TacGiaDAO();
                TacGiaDAO.XoaTacGia(maTacGia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
