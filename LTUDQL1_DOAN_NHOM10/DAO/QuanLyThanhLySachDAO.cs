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
    public class QuanLyThanhLySachDAO
    {
        Provider provider = new Provider();

        public DataTable LayThongTinSach(string MaSach)
        {
            try
            {
                string strSQL = "SELECT S.MaSach, S.TenSach, TG.TenTacGia, TL.TenTheLoai FROM TACGIA TG JOIN SACH S INNER JOIN THELOAISACH TL " +
                                "ON TL.MaTheLoai = S.MaTheLoai ON S.MaTacGia = TG.MaTacGia " +
                                "WHERE S.MaSach = @MaSach";
                provider.Connect();

                DataTable dtSach = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@MaSach", Value = MaSach });

                return dtSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayDanhSachLyDoThanhLy()
        {
            try
            {
                string strSQL = "SELECT MaLyDoThanhLy, MoTa FROM LyDoThanhLy ";
                provider.Connect();

                DataTable dtLyDo = provider.SELECT(CommandType.Text, strSQL);

                return dtLyDo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayThongTinNhanVien(string MaNhanVien)
        {
            try
            {
                string strSQL = "SELECT NV.HoTenNV, CV.TenChucVu, NV.NgaySinh FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu " +
                                "WHERE NV.MaNhanVien = @MaNhanVien";
                provider.Connect();

                DataTable dtNhanVien = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@MaNhanVien", Value = MaNhanVien });

                return dtNhanVien;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public DataTable LayMaPhieuLonNhat()
        {
            try
            {
                string strSQL = "SELECT TOP 1 MaPhieuThanhLy FROM  ThanhLySach ORDER BY MaPhieuThanhLy";
                provider.Connect();

                DataTable dtMaPhieuThanhLy = provider.SELECT(CommandType.Text, strSQL);

                return dtMaPhieuThanhLy;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int ThemPhieuThanhLySach(PhieuThanhLySachDTO phieuThanhLySach)
        {
            try
            {
                string strSQL = "INSERT INTO THANHLYSACH VALUES(@MaPhieuThanhLy, @MaNV, @NgayThanhLy)";
                provider.Connect();

                int Row = provider.ExecuteNonQuery(CommandType.Text, strSQL, 
                    new SqlParameter { ParameterName = "@MaPhieuThanhLy", Value = phieuThanhLySach.MaPhieuthanhLy},
                    new SqlParameter { ParameterName = "@MaNV", Value = phieuThanhLySach.MaNV },
                    new SqlParameter { ParameterName = "@NgayThanhLy", Value = phieuThanhLySach.NgayThanhLy }
                    );

                return Row;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int ThemChiTietPhieuThanhLySach(ChiTietPhieuThanhLySachDTO phieuChiTietThanhLySach)
        {
            try
            {
                string strSQL = "INSERT INTO CT_PHIEUTHANHLY VALUES(@MaPhieuThanhLy, @MaSach, @MaLyDoThanhLy)";
                provider.Connect();

                int Row = provider.ExecuteNonQuery(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@MaPhieuThanhLy", Value = phieuChiTietThanhLySach.MaPhieuThanhLy },
                    new SqlParameter { ParameterName = "@MaSach", Value = phieuChiTietThanhLySach.MaSach },
                    new SqlParameter { ParameterName = "@MaLyDoThanhLy", Value = phieuChiTietThanhLySach.MaLyDoThanhLy }
                    );

                return Row;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public int XoaSach(string MaSach)
        {
            try
            {
                string strSQL = "UPDATE SACH SET TTS = 'TTS03' WHERE MaSach=@MaSach";
                provider.Connect();

                int Row = provider.ExecuteNonQuery(CommandType.Text, strSQL,                
                    new SqlParameter { ParameterName = "@MaSach", Value = MaSach }
                    );

                return Row;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }


        public void ThemQuanLyThanhLySach(string tenQuanLyThanhLySach, string maQuanLyThanhLySach)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "INSERT INTO LyDoThanhLy VALUES(@MaQuanLyThanhLySach, @LoaiQuanLyThanhLySach)";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaQuanLyThanhLySach", Value = maQuanLyThanhLySach },
                    new SqlParameter { ParameterName = "@LoaiQuanLyThanhLySach", Value = tenQuanLyThanhLySach });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

        public void SuaQuanLyThanhLySach(string tenQuanLyThanhLySach, string maQuanLyThanhLySach)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "UPDATE LyDoThanhLy SET MoTa = @MoTa WHERE MaLyDoThanhLy = @MaLyDoThanhLy";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaLyDoThanhLy", Value = maQuanLyThanhLySach },
                    new SqlParameter { ParameterName = "@MoTa", Value = tenQuanLyThanhLySach });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public void XoaQuanLyThanhLySach(string maQuanLyThanhLySach)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string query = "DELETE LyDoThanhLy WHERE MaLyDoThanhLy = @MaLyDoThanhLy";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaLyDoThanhLy", Value = maQuanLyThanhLySach });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
