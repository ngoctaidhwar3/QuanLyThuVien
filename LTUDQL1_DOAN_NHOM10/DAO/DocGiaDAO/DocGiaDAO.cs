using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DocGiaDAO
{
    public class DocGiaDAO
    {
		Provider provider = new Provider();
		public DataTable LayDanhSachDocGia()
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM DocGia";
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


		public void ThemDocGia(DocGiaDTO DocGia)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO DocGia(MaDocGia, HoTenDG, DiaChi, NgaySinh, Email, NgayLapThe, NgayHetHan,TongNo, MaLoaiDG,NVLapThe,TTDG)" +
						" VALUES(@MaDocGia, @HoTenDG, @DiaChi, @NgaySinh, @Email, @NgayLapThe, @NgayHetHan,@TongNo, @MaLoaiDG,@NVLapThe, @TTDG)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaDocGia", Value = DocGia.MaDocGia },
					new SqlParameter { ParameterName = "@HoTenDG", Value = DocGia.HoTenDG },
					new SqlParameter { ParameterName = "@DiaChi", Value = DocGia.DiaChi },
					new SqlParameter { ParameterName = "@NgaySinh", Value = DocGia.NgaySinh },
					new SqlParameter { ParameterName = "@Email", Value = DocGia.Email },
					new SqlParameter { ParameterName = "@NgayLapThe", Value = DocGia.NgayLapThe },
					new SqlParameter { ParameterName = "@NgayHetHan", Value = DocGia.NgayHetHan },
					new SqlParameter { ParameterName = "@MaLoaiDG", Value = DocGia.MaLoaiDG },
					new SqlParameter { ParameterName = "@NVLapThe", Value = DocGia.NvLapThe },
					new SqlParameter { ParameterName = "@TongNo", Value = DocGia.TongNo },
					new SqlParameter { ParameterName = "@TTDG", Value = DocGia.TTDG });
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

		public void CapNhatDocGia(DataTable dtDocGia)
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM DocGia";
				provider.AdapterUpdate(query, dtDocGia);
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
