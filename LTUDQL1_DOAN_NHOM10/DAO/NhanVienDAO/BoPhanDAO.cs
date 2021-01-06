using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BoPhanDAO
	{
		Provider provider = new Provider();
		public DataTable LayDanhSachBoPhan()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM BoPhan";
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

		public void ThemBoPhan(string tenBoPhan, string maBoPhan)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO BoPhan VALUES(@MaBoPhan, @TenBoPhan)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaBoPhan", Value = maBoPhan },
					new SqlParameter { ParameterName = "@TenBoPhan", Value = tenBoPhan });
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

		public void SuaBoPhan(string tenBoPhan, string maBoPhan)
		{
			try
			{
				provider.Connect();
				string query = "UPDATE BoPhan SET TenBoPhan = @TenBoPhan WHERE MaBoPhan = @MaBoPhan";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaBoPhan", Value = maBoPhan },
					new SqlParameter { ParameterName = "@TenBoPhan", Value = tenBoPhan });
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
		public void XoaBoPhan(string maBoPhan)
		{
			try
			{
				provider.Connect();
				string query = "DELETE BoPhan WHERE MaBoPhan = @MaBoPhan";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaBoPhan", Value = maBoPhan });
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
