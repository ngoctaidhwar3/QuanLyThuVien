using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ChucVuDAO
	{
		Provider provider = new Provider();
		public DataTable LayDanhSachChucVu()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM ChucVu";
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


		public void ThemChucVu(string tenChucVu, string maChucVu)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO ChucVu VALUES(@MaChucVu, @TenChucVu)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaChucVu", Value = maChucVu },
					new SqlParameter { ParameterName = "@TenChucVu", Value = tenChucVu });
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

		public void SuaChucVu(string tenChucVu, string maChucVu)
		{
			try
			{
				provider.Connect();
				string query = "UPDATE ChucVu SET TenChucVu = @TenChucVu WHERE MaChucVu = @MaChucVu";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaChucVu", Value = maChucVu },
					new SqlParameter { ParameterName = "@TenChucVu", Value = tenChucVu });
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
		public void XoaChucVu(string maChucVu)
		{
			try
			{
				provider.Connect();
				string query = "DELETE ChucVu WHERE MaChucVu = @MaChucVu";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaChucVu", Value = maChucVu });
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
