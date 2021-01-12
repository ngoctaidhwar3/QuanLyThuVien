using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TinhTrangNhanVienDAO
	{
		Provider provider = new Provider();
		public DataTable LayDanhSachTinhTrangNhanVien()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM TinhTrangNhanVien";
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


		public void ThemTinhTrang(string tenTinhTrang, string maTinhTrang)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO TinhTrangNhanVien VALUES(@MaTinhTrang, @LoaiTinhTrang)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaTinhTrang", Value = maTinhTrang },
					new SqlParameter { ParameterName = "@LoaiTinhTrang", Value = tenTinhTrang });
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

		public void SuaTinhTrang(string tenTinhTrang, string maTinhTrang)
		{
			try
			{
				provider.Connect();
				string query = "UPDATE TinhTrangNhanVien SET LoaiTinhTrang = @LoaiTinhTrang WHERE MaTinhTrangNV = @MaTinhTrang";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaTinhTrang", Value = maTinhTrang },
					new SqlParameter { ParameterName = "@LoaiTinhTrang", Value = tenTinhTrang });
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
		public void XoaTinhTrang(string maTinhTrang)
		{
			try
			{
				provider.Connect();
				string query = "DELETE TinhTrangNhanVien WHERE MaTinhTrangNV = @MaTinhTrang";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaTinhTrang", Value = maTinhTrang });
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
