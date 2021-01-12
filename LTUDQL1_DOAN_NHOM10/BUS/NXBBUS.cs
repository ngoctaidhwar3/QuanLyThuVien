using DAO;
using System;
using System.Data;

namespace BUS
{
    public class NXBBUS
    {
        public DataTable LayDanhSachNXB()
        {
            try
            {
                NXBDAO NXBDAO = new NXBDAO();
                return NXBDAO.LayDanhSachNXB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThemNXB(string tenNXB)
        {
            try
            {
                NXBDAO NXBDAO = new NXBDAO();
                DataTable dsNXB = NXBDAO.LayDanhSachNXB();
                string maNXB = "NXB" + (int.Parse(dsNXB.Rows[dsNXB.Rows.Count - 1][0].ToString().Substring(3, 3)) + 1).ToString("000");
                NXBDAO.ThemNXB(maNXB, tenNXB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SuaNXB(string maNXB, string tenNXB)
        {
            try
            {
                NXBDAO NXBDAO = new NXBDAO();
                NXBDAO.SuaNXB(maNXB, tenNXB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void XoaNXB(string maNXB)
        {
            try
            {
                NXBDAO NXBDAO = new NXBDAO();
                NXBDAO.XoaNXB(maNXB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
