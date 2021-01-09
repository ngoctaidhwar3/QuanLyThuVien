using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuyDinhBUS
    {
        public DataTable LayDanhSachQuyDinh()
        {
            try
            {
                QuyDinhDAO dsBoPhan = new QuyDinhDAO();
                DataTable table = dsBoPhan.LayDanhSachQuyDinh();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void CapNhatQuyDinh(DataTable dtQuyDinh)
        {
            try
            {
                QuyDinhDAO QuyDinh = new QuyDinhDAO();
                QuyDinh.CapNhatQuyDinh(dtQuyDinh);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
