using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TinhTrangSachDAO
    {
        Provider provider = new Provider();
        public DataTable LayDanhSachTinhTrangSach()
        {
            try
            {
                provider.Connect();
                string query = "SELECT * FROM TinhTrangSach";
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

        public void ThemTinhTrangSach(string maTTS, string tenTTS)
        {
            try
            {
                provider.Connect();
                string query = "INSERT INTO TinhTrangSach VALUES(@MaTTS, @TenTTS)";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaTTS", Value = maTTS },
                    new SqlParameter { ParameterName = "@TenTTS", Value = tenTTS });
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

        public void SuaTinhTrangSach(string maTTS, string tenTTS)
        {
            try
            {
                provider.Connect();
                string query = "UPDATE TinhTrangSach SET TenTinhTrang = @TenTTS WHERE MaTTSach = @MaTTS";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaTTS", Value = maTTS },
                    new SqlParameter { ParameterName = "@TenTTS", Value = tenTTS });
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

        public void XoaTinhTrangSach(string maTTS)
        {
            try
            {
                provider.Connect();
                string query = "DELETE TinhTrangSach WHERE MaTTSach = @MaTTS";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaTTS", Value = maTTS });
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
