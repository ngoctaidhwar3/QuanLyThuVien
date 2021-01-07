using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TinhTrangSachBUS
    {
        public DataTable LayDanhSachTinhTrangSach()
        {
            try
            {
                TinhTrangSachDAO TTSDAO = new TinhTrangSachDAO();
                return TTSDAO.LayDanhSachTinhTrangSach();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ThemTinhTrangSach(string tenTTS)
        {
            try
            {
                TinhTrangSachDAO TTSDAO = new TinhTrangSachDAO();
                DataTable dsTTS = TTSDAO.LayDanhSachTinhTrangSach();
                string maTTS = "TTS" + (int.Parse(dsTTS.Rows[dsTTS.Rows.Count - 1][0].ToString().Substring(3, 2)) + 1).ToString("00");
                TTSDAO.ThemTinhTrangSach(maTTS, tenTTS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SuaTinhTrangSach(string maTTS, string tenTTS)
        {
            try
            {
                TinhTrangSachDAO TTSDAO = new TinhTrangSachDAO();
                TTSDAO.SuaTinhTrangSach(maTTS, tenTTS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void XoaTinhTrangSach(string maTTS)
        {
            try
            {
                TinhTrangSachDAO TTSDAO = new TinhTrangSachDAO();
                TTSDAO.XoaTinhTrangSach(maTTS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
