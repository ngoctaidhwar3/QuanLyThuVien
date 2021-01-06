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
    public class QuanLyPhieuMuonDAO
    {
        Provider provider = new Provider();
        public DataTable LaySachTrongPhieuMuon(string MaSach)
        {
            try
            {
                string strSQL = "SELECT S.TenSach, TG.TenTacGia, TL.TenTheLoai, S.TTS" +
                                " FROM SACH S, TACGIA TG, THELOAISACH TL" +
                                " WHERE S.MaSach = @MaSach AND S.MaTacGia = TG.MaTacGia AND S.MaTheLoai = TL.MaTheLoai";
                provider.Connect();
                DataTable dtTable = provider.SELECT(CommandType.Text, strSQL,
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

        public DataTable LayDocGia(string MaDG)
        {
            try
            {
                string strSQL = "SELECT DG.HoTenDG, DG.NgaySinh, DG.TTDG, LDG.TenLoaiDG, DG.TongNo FROM DOCGIA DG, LOAIDOCGIA LDG Where MaDocGia = @MaDG AND DG.MaLoaiDG = LDG.MaLoaiDG";
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

        public DataTable LayQuyDinh()
        {
            try
            {
                string strSQL = "SELECT * FROM QuyDinh";
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

        public DataTable LayMaPhieuMuon()
        {
            try
            {
                string strSQL = "SELECT TOP(1) MaPM FROM PHIEUMUONSACH ODER BY MaPM";
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

        public int ThemPhieuMuon(PhieuMuonDTO PM)
        {
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO PhieuMuonSach VALUES(@MaPM,@NgayMuon,@MaDG,@NgayHetHan)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSQL,
                           new SqlParameter { ParameterName = "@MaPM", Value = PM.MaPM },
                           new SqlParameter { ParameterName = "@NgayMuon", Value = PM.NgayMuon },
                           new SqlParameter { ParameterName = "@MaDG", Value = PM.MaDG },
                           new SqlParameter { ParameterName = "@NgayHetHan", Value = PM.NgayHetHan }
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

        public int ThemChiTietPhieuMuon(CT_PhieuMuonDTO CTPM)
        {
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO CT_PHIEUMUON VALUES(@MaPM, @MaSach)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSQL,
                           new SqlParameter { ParameterName = "@MaPM", Value = CTPM.MaPM },
                           new SqlParameter { ParameterName = "@MaSach", Value = CTPM.MaSach });
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
                string strSQL = "UPDATE SACH SET TTS = 'TTS01' WHERE MaSach = @MaSach";
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
