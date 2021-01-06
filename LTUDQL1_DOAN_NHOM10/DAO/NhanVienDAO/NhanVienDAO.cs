using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
	{
		Provider provider = new Provider();
		public DataTable LayDanhSachNhanVien()
        {
			try
			{
				provider.Connect();
				string query = "SELECT * FROM NhanVien";
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

		public DataTable LayDanhSachNhanVienTheoBoPhan(string maBoPhan)
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM NhanVien WHERE MaBoPhan = '" + maBoPhan+ "'";
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

		public void ThemNhanVien(NhanVienDTO nhanVien)
		{
			try
			{
				provider.Connect();
				string query = "INSERT INTO NhanVien(MaNhanVien, HoTenNV, DiaChi, NgaySinh, DienThoai, MaBangCap, MaChucVu, MaBoPhan,MaTTNV)" +
					" VALUES(@MaNhanVien, @HoTenNV, @DiaChi, @NgaySinh, @DienThoai, @MaBangCap, @MaChucVu, @MaBoPhan, @MaTTNV)";
				provider.ExecuteNonQuery(CommandType.Text, query,
					new SqlParameter { ParameterName = "@MaNhanVien", Value = nhanVien.MaNhanVien },
					new SqlParameter { ParameterName = "@HoTenNV", Value = nhanVien.HoTenNV },
					new SqlParameter { ParameterName = "@DiaChi", Value = nhanVien.DiaChi },
					new SqlParameter { ParameterName = "@NgaySinh", Value = nhanVien.NgaySinh },
					new SqlParameter { ParameterName = "@DienThoai", Value = nhanVien.DienThoai },
					new SqlParameter { ParameterName = "@MaBangCap", Value = nhanVien.BangCap },
					new SqlParameter { ParameterName = "@MaChucVu", Value = nhanVien.ChucVu },
					new SqlParameter { ParameterName = "@MaBoPhan", Value = nhanVien.BoPhan },
					new SqlParameter { ParameterName = "@MaTTNV", Value = nhanVien.MaTTNV });
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

		public void CapNhatNhanVien(DataTable dtNhanVien)
		{
			try
			{
				provider.Connect();
				string query = "SELECT * FROM NhanVien";
				provider.AdapterUpdate(query, dtNhanVien);
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
