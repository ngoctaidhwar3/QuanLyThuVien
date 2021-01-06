using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DAO.SachDAO
    {
        public class TheLoaiDAO
        {
            Provider provider = new Provider();
            public DataTable LayDanhSachTheLoai()
            {
                try
                {
                    provider.Connect();
                    string query = "SELECT * FROM TheLoaiSach";
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

            public void ThemTheLoai(string maTheLoai, string tenTheLoai)
            {
                try
                {
                    provider.Connect();
                    string query = "INSERT INTO TheLoaiSach VALUES(@MaTheLoai, @TenTheLoai)";
                    provider.ExecuteNonQuery(CommandType.Text, query,
                        new SqlParameter { ParameterName = "@MaTheLoai", Value = maTheLoai },
                        new SqlParameter { ParameterName = "@TenTheLoai", Value = tenTheLoai });
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

            public void SuaTheLoai(string maTheLoai, string tenTheLoai)
            {
                try
                {
                    provider.Connect();
                    string query = "UPDATE TheLoaiSach SET TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai";
                    provider.ExecuteNonQuery(CommandType.Text, query,
                        new SqlParameter { ParameterName = "@MaTheLoai", Value = maTheLoai },
                        new SqlParameter { ParameterName = "@TenTheLoai", Value = tenTheLoai });
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
            public void XoaTheLoai(string maTheLoai)
            {
                try
                {
                    provider.Connect();
                    string query = "DELETE TheLoaiSach WHERE MaTheLoai = @MaTheLoai";
                    provider.ExecuteNonQuery(CommandType.Text, query,
                        new SqlParameter { ParameterName = "@MaTheLoai", Value = maTheLoai });
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

}
