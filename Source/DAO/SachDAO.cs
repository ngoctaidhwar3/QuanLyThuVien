using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SachDAO
    {
        static Provider provider = new Provider();
        public static bool WasExistBookId(string bookId)
        {
            provider.Connect();
            try
            {
                string cmd = "SELECT * FROM SACH WHERE MaSach = '" + bookId + "'";
                var dt = provider.SELECT(System.Data.CommandType.Text, cmd);
                return dt.Rows.Count != 0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public static DataTable GetDatasByCommand(string cmd)
        { 
            try
            {
                provider.Connect(); ;
                DataTable dt = provider.SELECT(CommandType.Text, cmd);
                return dt;
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

        public static DataTable GetDatasByStoredProcedure(string cmd)
        {
            try
            {
                provider.Connect(); ;
                DataTable dt = provider.SELECT(CommandType.StoredProcedure, cmd);
                return dt;
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

       
        public static int AddANewBook(SachDTO book)
        {
            int nRow = 0;
            try
            {
                string strSql = "INSERT INTO SACH(MaSach, TenSach, MaTheLoai, MaTacGia, TTS, MaNXB, NgayXuatBan, GiaTien, Ke, NgayNhap, MaNVTiepNhan)" +
                    " VALUES(@Ma, @Ten, @MaTheLoai, @MaTacGia, @TTS, @MaNXB, @NgayXuatBan, @GiaTien, @Ke, @NgayNhap, @MaNVTN)";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.Text, strSql,
                            new SqlParameter { ParameterName = "@Ma", Value = book.Ma },
                            new SqlParameter { ParameterName = "@Ten", Value = book.Ten },
                            new SqlParameter { ParameterName = "@MaTheLoai", Value = book.MaTheLoai },
                            new SqlParameter { ParameterName = "@MaTacGia", Value = book.MaTacGia },
                            new SqlParameter { ParameterName = "@TTS", Value = "TTS02" },
                            new SqlParameter { ParameterName = "@MaNXB", Value = book.MaMXB },
                            new SqlParameter { ParameterName = "@NgayXuatBan", Value = book.NgayXuatBan},
                            new SqlParameter { ParameterName = "@Giatien", Value = book.GiaTien },
                            new SqlParameter { ParameterName = "@Ke", Value = book.ViTri },
                            new SqlParameter { ParameterName = "@NgayNhap", Value = book.NgayTiepNhan},
                            new SqlParameter { ParameterName = "@MaNVTN", Value = book.MaNVTiepNhan }
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

        public static DataTable FindBook(SachDTO book)
        {
            try
            {
                provider.Connect();
                string strSql = "SELECT S.MaSach, S.TenSach, TL.TenTheLoai, T.TenTacGia, N.TenNXB, S.GiaTien, TR.TenTinhTrang, S.Ke "
                +"FROM SACH S, TACGIA T, THELOAISACH TL, NHAXUATBAN N, TINHTRANGSACH TR "
                +"WHERE (@name LIKE '' or S.TenSach LIKE '%' + @name + '%') "
                +"AND (@category_id IS NULL OR S.MaTheLoai = @category_id AND S.MaTheLoai = TL.MaTheLoai) "
                +"AND (@author_id IS NULL OR S.MaTacGia = @author_id AND S.MaTacGia = T.MaTacGia) "
                +"AND(@publisher_id IS NULL OR S.MaNXB = @publisher_id AND S.MaNXB = N.MaNXB) "
                +"AND S.TTS = TR.MaTTSach";
                DataTable dt = provider.SELECT(CommandType.Text, strSql,
                                    new SqlParameter { ParameterName = "@name", Value = book.Ten },
                                    new SqlParameter { ParameterName = "@category_id", Value = book.MaTheLoai },
                                    new SqlParameter { ParameterName = "@author_id", Value = book.MaTacGia },
                                    new SqlParameter { ParameterName = "@publisher_id", Value = book.MaMXB });
                return dt;
            }
            catch(SqlException ex)
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
