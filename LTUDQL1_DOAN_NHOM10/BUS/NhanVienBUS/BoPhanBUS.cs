using DAO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BoPhanBUS
    {
        public DataTable LayDanhSachBoPhan()
        {
            try
            {
                BoPhanDAO dsBoPhan = new BoPhanDAO();
                DataTable table = dsBoPhan.LayDanhSachBoPhan();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemBoPhan(string tenBoPhan)
        {
            try
            {
                BoPhanDAO BoPhan = new BoPhanDAO();
                DataTable dsBoPhan = BoPhan.LayDanhSachBoPhan();
                string maBoPhan = "BP" + (int.Parse(dsBoPhan.Rows[dsBoPhan.Rows.Count - 1][0].ToString().Substring(2, 2)) + 1).ToString("00");
                BoPhan.ThemBoPhan(tenBoPhan, maBoPhan);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SuaBoPhan(string tenBoPhan, string maBoPhan)
        {
            try
            {
                BoPhanDAO BoPhan = new BoPhanDAO();
                BoPhan.SuaBoPhan(tenBoPhan, maBoPhan);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void XoaBoPhan(string maBoPhan)
        {
            try
            {
                BoPhanDAO BoPhan = new BoPhanDAO();
                BoPhan.XoaBoPhan(maBoPhan);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
