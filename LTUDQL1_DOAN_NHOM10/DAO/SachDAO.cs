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
    public class SachDAO
    {
        Provider provider = new Provider();
        public bool WasExistBookId(string bookId)
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
        public DataTable GetDatasByCommand(string cmd)
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

        public DataTable GetDatasByStoredProcedure(string cmd)
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

       
        public int AddANewBook(Sach book)
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

        public DataTable FindBook(Sach book)
        {
            try
            {
                provider.Connect();
                string cmd = "USP_FindBook";
                DataTable dt = provider.SELECT(CommandType.StoredProcedure, cmd,
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
