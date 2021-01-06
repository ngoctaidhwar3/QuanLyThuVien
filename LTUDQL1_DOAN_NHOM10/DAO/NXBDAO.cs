using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NXBDAO
    {
        Provider provider = new Provider();
        public DataTable LayDanhSachNXB()
        {
            try
            {
                provider.Connect();
                string query = "SELECT * FROM NHAXUATBAN";
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

        public void ThemNXB(string maNXB, string tenNXB)
        {
            try
            {
                provider.Connect();
                string query = "INSERT INTO NHAXUATBAN " +
                    "VALUES(@MaNXB, @TenNXB)";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaNXB", Value = maNXB },
                    new SqlParameter { ParameterName = "@TenNXB", Value = tenNXB });
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

        public void SuaNXB(string maNXB, string tenNXB)
        {
            try
            {
                provider.Connect();
                string query = "UPDATE NHAXUATBAN set TenNXB = @TenNXB where MaNXB = @MaNXB";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaNXB", Value = maNXB },
                    new SqlParameter { ParameterName = "@TenNXB", Value = tenNXB });
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

        public void XoaNXB(string maNXB)
        {
            try
            {
                provider.Connect();
                string query = "DELETE NHAXUATBAN where MaNXB = @MaNXB";
                provider.ExecuteNonQuery(CommandType.Text, query,
                    new SqlParameter { ParameterName = "@MaNXB", Value = maNXB });
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
