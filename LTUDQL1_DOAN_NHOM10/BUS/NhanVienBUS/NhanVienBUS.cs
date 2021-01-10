using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        public string LayMaNhanVienMoi()
        {
            try
            {
                NhanVienDAO dsNhanVien = new NhanVienDAO();
                DataTable table = dsNhanVien.LayDanhSachNhanVien();
                string MaCu = table.Rows[table.Rows.Count - 1].ItemArray[0].ToString();
                int STT = int.Parse(MaCu.Substring(2, 4)) + 1;
                string MaMoi = "NV" + STT.ToString("0000");
                return MaMoi;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                NhanVienDAO dsNhanVien = new NhanVienDAO();
                DataTable table = dsNhanVien.LayDanhSachNhanVien();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayDanhSachNhanVienTheoBoPhan(string maBoPhan)
        {
            try
            {
                NhanVienDAO dsNhanVien = new NhanVienDAO();
                DataTable table = dsNhanVien.LayDanhSachNhanVienTheoBoPhan(maBoPhan);
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemNhanVien(NhanVienDTO nhanVien)
        {
            try
            {
                NhanVienDAO NhanVien = new NhanVienDAO();
                NhanVien.ThemNhanVien(nhanVien);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CapNhatNhanVien(DataTable dtNhanVien)
        {
            try
            {
                NhanVienDAO NhanVien = new NhanVienDAO();
                NhanVien.CapNhatNhanVien(dtNhanVien);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
