using DAO;
using System;
using System.Data;

namespace BUS
{
    public class QuanLyBaoCaoBUS
    {
        public DataTable LayThongTinBaoCaoDocGiaNoTienPhat(string NgayBaoCao)
        {
            try
            {
                QuanLyBaoCaoDAO quanLyBaoCaoDAO = new QuanLyBaoCaoDAO();
                return quanLyBaoCaoDAO.LayThongTinBaoCaoDocGiaNoTienPhat(NgayBaoCao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayThongTinBaoCaoSachTraTre(string NgayBaoCao)
        {
            try
            {
                QuanLyBaoCaoDAO quanLyBaoCaoDAO = new QuanLyBaoCaoDAO();
                return quanLyBaoCaoDAO.LayThongTinBaoCaoSachTraTre(NgayBaoCao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LayThongTinBaoCaoMuonSachTheoTheLoai(string ThangBaoCao)
        {
            try
            {
                QuanLyBaoCaoDAO quanLyBaoCaoDAO = new QuanLyBaoCaoDAO();
                return quanLyBaoCaoDAO.LayThongTinBaoCaoMuonSachTheoTheLoai(ThangBaoCao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
