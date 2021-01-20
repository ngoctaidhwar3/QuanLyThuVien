using DAO.DocGiaDAO;
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BUS.DocGiaBUS
{
    public class DocGiaBUS
    {

        public string LayMaDocGiaMoi()
        {
            try
            {
                DocGiaDAO dsDocGia = new DocGiaDAO();
                DataTable table = dsDocGia.LayDanhSachDocGia();
                string MaCu = table.Rows[table.Rows.Count - 1].ItemArray[0].ToString();
                int STT = int.Parse(MaCu.Substring(2, 4)) + 1;
                string MaMoi = "DG" + STT.ToString("0000");
                return MaMoi;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable LayDanhSachDocGia()
        {
            try
            {
                DocGiaDAO dsDocGia = new DocGiaDAO();
                DataTable table = dsDocGia.LayDanhSachDocGia();
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable LayDanhSachDocGia(int rs)
        {
            try
            {
                DocGiaDAO dsDocGia = new DocGiaDAO();
                DataTable table = dsDocGia.LayDanhSachDocGia(rs);
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void ThemDocGia(DocGiaDTO DocGia)
        {
            try
            {
                DocGiaDAO docGia = new DocGiaDAO();
                docGia.ThemDocGia(DocGia);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CapNhatDocGia(DataTable dtDocGia)
        {
            try
            {
                DocGiaDAO DocGia = new DocGiaDAO();
                DocGia.CapNhatDocGia(dtDocGia);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
