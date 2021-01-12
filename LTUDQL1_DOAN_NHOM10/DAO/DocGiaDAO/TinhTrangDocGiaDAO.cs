using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO.DocGiaDAO
{
    public class TinhTrangDocGiaDAO
	{
		Provider provider = new Provider();
		public DataTable LayDanhSachTinhTrangDocGia()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM TinhTrangDocGia";
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

		public void ThemTinhTrangDG(string tenTinhTrangDG, string maTinhTrangDG)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO TinhTrangDocGia VALUES(@MaTinhTrangDG, @LoaiTinhTrangDG)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaTinhTrangDG", Value = maTinhTrangDG },
					new SqlParameter { ParameterName = "@LoaiTinhTrangDG", Value = tenTinhTrangDG });
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

		public void SuaTinhTrangDG(string tenTinhTrangDG, string maTinhTrangDG)
		{
			try
			{
				provider.Connect();
				string query = "UPDATE TinhTrangDocGia SET LoaiTinhTrangDG = @LoaiTinhTrangDG WHERE MaTinhTrangDG = @MaTinhTrangDG";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaTinhTrangDG", Value = maTinhTrangDG },
					new SqlParameter { ParameterName = "@LoaiTinhTrangDG", Value = tenTinhTrangDG });
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
		public void XoaTinhTrangDG(string maTinhTrangDG)
		{
			try
			{
				provider.Connect();
				string query = "DELETE TinhTrangDocGia WHERE MaTinhTrangDG = @MaTinhTrangDG";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaTinhTrangDG", Value = maTinhTrangDG });
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
