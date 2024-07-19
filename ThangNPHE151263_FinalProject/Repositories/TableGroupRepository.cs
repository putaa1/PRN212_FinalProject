using ThangNPHE151263_FinalProject.Models;

namespace Repositories
{
    public class TableGroupRepository
    {
        private MilkTeaContext _context;

        public List<GroupTable> GetAll()
        {
            _context = new MilkTeaContext();
            return _context.GroupTables.ToList();
        }
    }
}
