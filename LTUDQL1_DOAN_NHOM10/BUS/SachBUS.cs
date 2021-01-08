using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {
        public static bool WasExistBookId(string bookId)
        {
            return DAO.SachDAO.WasExistBookId(bookId);
        }

        public static DataTable GetDatasByCommand(string cmd)
        {
            return DAO.SachDAO.GetDatasByCommand(cmd);
        }

        public static DataTable GetDatasByStoredProcedure(string cmd)
        {
            return DAO.SachDAO.GetDatasByStoredProcedure(cmd);
        }

        public static int AddANewBook(DTO.Sach book)
        {
            return DAO.SachDAO.AddANewBook(book);
        }

        public static DataTable FindBook(DTO.Sach book)
        {
            return DAO.SachDAO.FindBook(book);
        }
    }
}
