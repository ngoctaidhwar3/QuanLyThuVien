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
    public class GhiNhanMatSachBUS
    {
        public DataTable MaGhiNhanSachMat()
        {
            try
            {
                GhiNhanMatSachDAO dao = new GhiNhanMatSachDAO();
                return dao.MaGhiNhanSachMat();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public DataTable DanhSachNhanVienThuThu()
        {
            try
            {
                GhiNhanMatSachDAO dao = new GhiNhanMatSachDAO();
                return dao.DanhSachNhanVienThuThu();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhatPhieuTra(GhiNhanMatSachDTO gnms)
        {
            try
            {
                GhiNhanMatSachDAO dao = new GhiNhanMatSachDAO();
                return dao.CapNhatPhieuTra(gnms);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemSachMat(GhiNhanMatSachDTO gnms)
        {
            try
            {
                GhiNhanMatSachDAO dao = new GhiNhanMatSachDAO();
                return dao.ThemSachMat(gnms);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable SachDocGia()
        {
            try
            {
                GhiNhanMatSachDAO dao = new GhiNhanMatSachDAO();
                return dao.SachDocGia();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
