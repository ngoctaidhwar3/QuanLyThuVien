using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DocGiaDAO
{
    public class LoaiDocGiaDAO
    {
		Provider provider = new Provider();
		public DataTable LayDanhSachLoaiDocGia()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM LoaiDocGia";
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

		public void ThemLoaiDocGia(string tenLoaiDocGia, string maLoaiDocGia)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO LoaiDocGia VALUES(@MaLoaiDocGia, @LoaiLoaiDocGia)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaLoaiDocGia", Value = maLoaiDocGia },
					new SqlParameter { ParameterName = "@LoaiLoaiDocGia", Value = tenLoaiDocGia });
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

		public void SuaLoaiDocGia(string tenLoaiDocGia, string maLoaiDocGia)
		{
			try
			{
				provider.Connect();
				string query = "UPDATE LoaiDocGia SET TenLoaiDG = @TenLoaiDG WHERE MaLoaiDG = @MaLoaiDG";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaLoaiDG", Value = maLoaiDocGia },
					new SqlParameter { ParameterName = "@TenLoaiDG", Value = tenLoaiDocGia });
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
		public void XoaLoaiDocGia(string maLoaiDocGia)
		{
			try
			{
				provider.Connect();
				string query = "DELETE LoaiDocGia WHERE MaLoaiDG = @MaLoaiDocGia";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaLoaiDocGia", Value = maLoaiDocGia });
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
