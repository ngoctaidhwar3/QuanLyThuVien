using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class SachBUS
    {
        public bool WasExistBookId(string bookId)
        {
            return SachDAO.WasExistBookId(bookId);
        }

        public DataTable GetDatasByCommand(string cmd)
        {
            return SachDAO.GetDatasByCommand(cmd);
        }

        public DataTable GetDatasByStoredProcedure(string cmd)
        {
            return SachDAO.GetDatasByStoredProcedure(cmd);
        }

        public int AddANewBook(SachDTO book)
        {
            return SachDAO.AddANewBook(book);
        }

        public DataTable FindBook(SachDTO book)
        {
            return SachDAO.FindBook(book);
        }
    }
}
