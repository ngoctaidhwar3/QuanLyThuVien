using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TacGiaDAO
    {
        Provider provider = new Provider();
        public DataTable LayDanhSachTacGia()
        {
            try
            {
                provider.Connect();
                string query = "SELECT * FROM TACGIA";
                DataTable table = provider.SELECT(CommandType.Text, query);
                return table;
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

        public void ThemTacGia(string maTacGia, string tenTacGia)
        {
            try
            {
                provider.Connect();
                string query = "INSERT INTO TACGIA VALUES(@MaTacGia, @TenTacGia)";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaTacGia", Value = maTacGia },
                    new SqlParameter { ParameterName = "@TenTacGia", Value = tenTacGia });
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

        public void SuaTacGia(string maTacGia, string tenTacGia)
        {
            try
            {
                provider.Connect();
                string query = "UPDATE TACGIA SET TenTacGia = @TenTacGia WHERE MaTacGia = @MaTacGia";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaTacGia", Value = maTacGia },
                    new SqlParameter { ParameterName = "@TenTacGia", Value = tenTacGia });
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
        public void XoaTacGia(string maTacGia)
        {
            try
            {
                provider.Connect();
                string query = "DELETE TACGIA WHERE MaTacGia = @MaTacGia";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaTacGia", Value = maTacGia });
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
