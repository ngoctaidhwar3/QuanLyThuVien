using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GhiNhanMatSachDAO
    {
        Provider pro = new Provider();
        public DataTable MaGhiNhanSachMat()
        { 
            DataTable dt = new DataTable();
            try
            {
                pro.Connect();
                string strSql = "SELECT MaGNMatSach FROM MATSACH ORDER BY MaGNMatSach DESC";
                dt = pro.SELECT(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                pro.DisConnect();
            }
        }
        public DataTable DanhSachNhanVienThuThu()
        {
            DataTable dt = new DataTable();
            try
            {
                pro.Connect();
                string strSql = "SELECT MaNhanVien FROM NHANVIEN WHERE MaBoPhan='BP02'";
                dt = pro.SELECT(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                pro.DisConnect();
            }
        }
        public int CapNhatPhieuTra(GhiNhanMatSachDTO gnms)
        {
            int nRow = 0;
            try
            {
                string strSql = "SP_CapNhatTienPhat";
                pro.Connect();
                nRow = pro.ExecuteNonQuery(CommandType.StoredProcedure, strSql, new SqlParameter { ParameterName = "@MaPT", Value = gnms.MaPT },
                                                                    new SqlParameter { ParameterName = "@TienNo", Value = gnms.TienNo },
                                                                    new SqlParameter { ParameterName = "@MaPM", Value = gnms.MaPM }
                                                                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                pro.DisConnect();
            }
            return nRow;
        }
        public int ThemSachMat(GhiNhanMatSachDTO gnms)
        {
            int nRow = 0;
            try
            {
                pro.Connect();
                string strSql = "Insert into MATSACH values(@MaGNMatSach,@MaSach,@NgayGhiNhan,@MaDG,@TienPhat,@MaNV)";
                nRow = pro.ExecuteNonQuery(CommandType.Text, strSql, new SqlParameter { ParameterName = "@MaGNMatSach", Value = gnms.MaGNMatSach },
                                                                                new SqlParameter { ParameterName = "@MaSach", Value = gnms.MaSach },
                                                                                new SqlParameter { ParameterName = "@NgayGhiNhan", Value = gnms.NgayGhiNhan },
                                                                                new SqlParameter { ParameterName = "@MaDG", Value = gnms.MaDG },
                                                                                new SqlParameter { ParameterName = "@TienPhat", Value = gnms.TienPhat },
                                                                                new SqlParameter { ParameterName = "@MaNV", Value = gnms.MaNV }
                                                                                );

                return nRow;

            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public DataTable SachDocGia()
        {
            DataTable dt = new DataTable();
            try
            {
                pro.Connect();
                string strSql = "SELECT pm.MaPM, pm.MaDG, ctpm.MaSach, s.GiaTien FROM CT_PHIEUMUON ctpm JOIN PHIEUMUONSACH pm ON ctpm.MaPM=pm.MaPM JOIN SACH s ON s.MaSach=ctpm.MaSach";
                dt = pro.SELECT(CommandType.Text, strSql);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                pro.DisConnect();
            }
        }
    }
}
