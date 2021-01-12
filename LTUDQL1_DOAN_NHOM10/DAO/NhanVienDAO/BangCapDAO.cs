using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class BangCapDAO
	{
		Provider provider = new Provider();
		public DataTable LayDanhSachBangCap()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM BangCap";
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

		public void ThemBangCap(string tenBangCap, string maBangCap)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO BangCap VALUES(@MaBangCap, @LoaiBangCap)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaBangCap", Value = maBangCap},
					new SqlParameter { ParameterName = "@LoaiBangCap", Value = tenBangCap});
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

		public void SuaBangCap(string tenBangCap, string maBangCap)
		{
			try
			{
				provider.Connect();
				string query = "UPDATE BangCap SET LoaiBangCap = @LoaiBangCap WHERE MaBangCap = @MaBangCap" ;
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaBangCap", Value = maBangCap },
					new SqlParameter { ParameterName = "@LoaiBangCap", Value = tenBangCap });
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
		public void XoaBangCap( string maBangCap)
		{
			try
			{
				provider.Connect();
				string query = "DELETE BangCap WHERE MaBangCap = @MaBangCap";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaBangCap", Value = maBangCap });
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
