using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class QuanLyBaoCaoDAO
    {
        Provider provider = new Provider();
        public DataTable LayThongTinBaoCaoDocGiaNoTienPhat(string NgayBaoCao)
        {
            try
            {
                string strSQL = "SELECT DG.HoTenDG, PTTP.ConLai FROM PHIEUTHUTIENPHAT PTTP INNER JOIN PHIEUTRASACH PTS INNER JOIN PHIEUMUONSACH PMS JOIN DOCGIA DG ON DG.MaDocGia = PMS.MaDG ON PMS.MaPM = PTS.MaPM ON PTS.MaPT = PTTP.MaPT " +
                                "WHERE PTTP.ConLai > 0 AND PTTP.NgayThu <= @NgayBaoCao";
                provider.Connect();

                DataTable dtBaoCao = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@NgayBaoCao", Value = NgayBaoCao});

                return dtBaoCao;
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

        public DataTable LayThongTinBaoCaoMuonSachTheoTheLoai(string ThangBaoCao)
        {
            try
            {
                string strSQL = "SELECT TLS.TenTheLoai, Count(S.MaSach) AS SoLuotMuon, " +
                                "Count(S.MaSach)*1.0 / (SELECT Count(S.MaSach) " +
                                "FROM PHIEUMUONSACH PMS INNER JOIN CT_PHIEUMUON CTPM INNER JOIN SACH S " +
                                "ON CTPM.MaSach = S.MaSach ON PMS.MaPM = CTPM.MaPM " +
                                "WHERE YEAR(PMS.NgayMuon) = YEAR(@ThangBaoCao) " +
                                "AND MONTH(PMS.NgayMuon) = MONTH(@ThangBaoCao)) AS TiLe " +
                                "FROM PHIEUMUONSACH PMS JOIN CT_PHIEUMUON CTPM JOIN SACH S JOIN THELOAISACH TLS " +
                                "ON S.MaTheLoai = TLS.MaTheLoai ON CTPM.MaSach = S.MaSach ON PMS.MaPM = CTPM.MaPM " +
                                "WHERE YEAR(PMS.NgayMuon) = YEAR(@ThangBaoCao) AND MONTH(PMS.NgayMuon) = MONTH(@ThangBaoCao) " +
                                "GROUP BY TLS.MaTheLoai, TLS.TenTheLoai";

                provider.Connect();

                DataTable dtBaoCao = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@ThangBaoCao", Value = ThangBaoCao });

                return dtBaoCao;
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

        public DataTable LayThongTinBaoCaoSachTraTre(string NgayBaoCao)
        {
            try
            {
                string strSQL = "SELECT S.TenSach, PMS.NgayMuon, PTS.SoNgayTraTre " +
                                "FROM PHIEUMUONSACH PMS JOIN PHIEUTRASACH PTS JOIN CT_PHIEUTRA CTPT INNER JOIN SACH S " +
                                "ON CTPT.MaSach = S.MaSach ON PTS.MaPT = CTPT.MaPT  ON PMS.MaPM = PTS.MaPM " +
                                "WHERE PTS.SoNgayTraTre > 0 AND PTS.NgayTra = @NgayBaoCao";
                provider.Connect();

                DataTable dtBaoCao = provider.SELECT(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@NgayBaoCao", Value = NgayBaoCao });

                return dtBaoCao;
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
