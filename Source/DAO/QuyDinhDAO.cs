using System;
using System.Data;

namespace DAO
{
    public class QuyDinhDAO
    {
		Provider provider = new Provider();
		public DataTable LayDanhSachQuyDinh()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM QuyDinh ";
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

		public void CapNhatQuyDinh(DataTable dtQuyDinh)
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM QuyDinh";
				provider.AdapterUpdate(query, dtQuyDinh);
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
