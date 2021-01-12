using DAO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BangCapBUS
    {
        public DataTable LayDanhSachBangCap()
        {
            try
            {
                BangCapDAO dsBangCap = new BangCapDAO();
                DataTable table = dsBangCap.LayDanhSachBangCap();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemBangCap(string tenBangCap)
        {
            try
            {
                BangCapDAO BangCap = new BangCapDAO();
                DataTable dsBangCap = BangCap.LayDanhSachBangCap();
                string maBangCap = "BC" + (int.Parse(dsBangCap.Rows[dsBangCap.Rows.Count - 1][0].ToString().Substring(2, 2)) + 1).ToString("00");
                BangCap.ThemBangCap(tenBangCap, maBangCap);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaBangCap(string tenBangCap, string maBangCap)
        {
            try
            {
                BangCapDAO BangCap = new BangCapDAO();
                BangCap.SuaBangCap(tenBangCap, maBangCap);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaBangCap(string maBangCap)
        {
            try
            {
                BangCapDAO BangCap = new BangCapDAO();
                BangCap.XoaBangCap(maBangCap);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
