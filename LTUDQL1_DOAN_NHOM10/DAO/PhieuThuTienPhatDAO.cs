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
    public class PhieuThuTienPhatDAO
    {
        Provider pro = new Provider();
        public DataTable LayDSDocGiaNo()
        {
            DataTable dt = new DataTable();
            try
            {
                pro.Connect();
                string strSql = "SELECT pm.MaDG, pt.MaPT, pt.TienNo FROM PHIEUTRASACH pt INNER JOIN PHIEUMUONSACH pm ON pt.MaPM=pm.MaPM WHERE pt.TienNo > 0";
                dt = pro.SELECT(CommandType.Text, strSql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                pro.DisConnect();
            }
            return dt;
        }
        public int UpDatePhieuTra(PhieuThuTienPhatDTO pttp)
        {
            int nRow = 0;
            try
            {
                string strSql = "UPDATE PHIEUTRASACH SET TienNo = @TienNo WHERE PHIEUTRASACH.MaPT=@MaPT";
                pro.Connect();
                nRow = pro.ExecuteNonQuery(CommandType.Text, strSql, new SqlParameter { ParameterName = "@MaPT", Value = pttp.MaPT },
                                                                     new SqlParameter { ParameterName = "@TienNo", Value = pttp.TienNo });
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
        public DataTable LayMaPhieuThu()
        {
            DataTable dt = new DataTable();
            try
            {
                pro.Connect();
                string strSql = "SELECT TOP 1 MaPhieuThu FROM PHIEUTHUTIENPHAT ORDER BY MaPhieuThu";
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
        public int ThemPhieuThuTienPhat(PhieuThuTienPhatDTO pttp)
        {
            int nRow = 0;
            try
            {
                pro.Connect();
                string strSql = "INSERT INTO PhieuThuTienPhat VALUES(@MaPhieuThu,@MaNV,@TienThu,@NgayThu,@MaPT,@TienConLai)";
                nRow = pro.ExecuteNonQuery(CommandType.Text, strSql, new SqlParameter { ParameterName = "@MaPhieuThu", Value = pttp.MaPhieuThu },
                                                                     new SqlParameter { ParameterName = "@MaNV", Value = pttp.MaNV },
                                                                     new SqlParameter { ParameterName = "@TienThu", Value = pttp.TienThu },
                                                                     new SqlParameter { ParameterName = "@NgayThu", Value = pttp.NgayThu },
                                                                     new SqlParameter { ParameterName = "@MaPT", Value = pttp.MaPT },
                                                                     new SqlParameter { ParameterName = "@TienConLai", Value = pttp.TienConLai }
                                                                     );
                return nRow;
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
        public DataTable DanhSachNhanVienThuQuy()
        {
            DataTable dt = new DataTable();
            try
            {
                pro.Connect();
                string strSql = "SELECT MaNhanVien FROM NHANVIEN WHERE MaBoPhan='BP04'";
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
