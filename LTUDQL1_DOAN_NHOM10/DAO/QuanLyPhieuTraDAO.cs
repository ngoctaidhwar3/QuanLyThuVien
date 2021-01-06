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
    public class QuanLyPhieuTraDAO
    {
        Provider provider = new Provider();
        public DataTable LayMaPhieuTra()
        {
            try
            {
                string strSQL = "SELECT TOP(1) MaPT FROM PHIEUTRASACH ORDER BY MaPT";
                provider.Connect();
                DataTable dtTable = provider.SELECT(CommandType.Text, strSQL);
                return dtTable;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable KiemTraDocGiaCoPhieuMuon(string MaDG)
        {
            try
            {
                string strSQL = "SELECT COUNT(*) AS N'Ton Tai' FROM PHIEUMUONSACH PM" +
                                  " WHERE PM.MaDG = @MaDG AND PM.MaPM NOT IN (SELECT PT.MaPM FROM PHIEUTRASACH PT)";

                provider.Connect();
                DataTable dtTable = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@MaDG", Value = MaDG });
                return dtTable;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable KiemTraSachCoTrongPhieuMuon(string MaDG, string MaSach)
        {
            try
            {
                string strSQL = "SELECT COUNT(*) AS N'Ton Tai', PM.NgayMuon, PM.MaPM FROM PHIEUMUONSACH PM, SACH S" +
                                " WHERE PM.MaDG = @MaDG AND @MaSach IN (SELECT CTPM.MaSach" +
                                " FROM CT_PHIEUMUON CTPM WHERE CTPM.MaPM = PM.MaPM) AND S.MaSach = @MaSach AND S.TTS = 'TTS01'" +
                                " GROUP BY PM.NgayMuon, PM.MaPM";
                provider.Connect();
                DataTable dtTable = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@MaDG", Value = MaDG },
                    new SqlParameter { ParameterName = "@MaSach", Value = MaSach });
                return dtTable;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int ThemPhieuTra(PhieuTraDTO PT)
        {
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO PhieuTraSach VALUES(@MaPT,@NgayTra,@MaPM,@TienPhatKyNay,@TienNo,@SoNgayTraTre)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSQL,
                           new SqlParameter { ParameterName = "@MaPT", Value = PT.MaPT },
                           new SqlParameter { ParameterName = "@MaPM", Value = PT.MaPM },
                           new SqlParameter { ParameterName = "@NgayTra", Value = PT.NgayTra },
                           new SqlParameter { ParameterName = "@TienPhatKyNay", Value = PT.TienPhatKyNay },
                           new SqlParameter { ParameterName = "@TienNo", Value = PT.TienNo },
                           new SqlParameter { ParameterName = "@SoNgayTraTre", Value = PT.SoNgayTraTre }
                   );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int ThemChiTietPhieuTra(CT_PhieuTraDTO CTPT)
        {
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO CT_PHIEUTRA VALUES(@MaPT, @MaSach,@NgayMuon,@SoNgayMuon,@TienPhat)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSQL,
                           new SqlParameter { ParameterName = "@MaPT", Value = CTPT.MaPT },
                           new SqlParameter { ParameterName = "@MaSach", Value = CTPT.MaSach },
                           new SqlParameter { ParameterName = "@NgayMuon", Value = CTPT.NgayMuon },
                           new SqlParameter { ParameterName = "@SoNgayMuon", Value = CTPT.SoNgayMuon },
                           new SqlParameter { ParameterName = "@TienPhat", Value = CTPT.TienPhat });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public int CapNhatTinhTrangSach(string MaSach)
        {
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE SACH SET TTS = 'TTS02' WHERE MaSach = @MaSach";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSQL,
                           new SqlParameter { ParameterName = "@MaSach", Value = MaSach });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
    }
}
