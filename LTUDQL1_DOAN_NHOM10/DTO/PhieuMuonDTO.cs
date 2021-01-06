using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonDTO
    {
        string maPM, maDG;

        public string MaDG
        {
            get { return maDG; }
            set { maDG = value; }
        }

        public string MaPM
        {
            get { return maPM; }
            set { maPM = value; }
        }
        DateTime ngayMuon, ngayHetHan;

        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }

    }
}
