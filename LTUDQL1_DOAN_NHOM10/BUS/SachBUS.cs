using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class SachBUS
    {
        public static bool WasExistBookId(string bookId)
        {
            return SachDAO.WasExistBookId(bookId);
        }

        public static DataTable GetDatasByCommand(string cmd)
        {
            return SachDAO.GetDatasByCommand(cmd);
        }

        public static DataTable GetDatasByStoredProcedure(string cmd)
        {
            return SachDAO.GetDatasByStoredProcedure(cmd);
        }

        public static int AddANewBook(Sach book)
        {
            return SachDAO.AddANewBook(book);
        }

        public static DataTable FindBook(Sach book)
        {
            return SachDAO.FindBook(book);
        }
    }
}
