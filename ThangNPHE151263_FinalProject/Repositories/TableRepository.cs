using Microsoft.EntityFrameworkCore;
using ThangNPHE151263_FinalProject.Models;

namespace Repositories
{
    public class TableRepository
    {
        private MilkTeaContext _context;

        public List<Table> GetAll()
        {
            _context = new MilkTeaContext();
            return _context.Tables.Include(table => table.IdGroupNavigation).ToList();
        }

        public List<Table> GetTableByGroup(long idGroup)
        {
            _context = new MilkTeaContext();
            return _context.Tables.Include("IdGroupNavigation").Where(table => table.IdGroup == idGroup).ToList();
        }
    }
}
