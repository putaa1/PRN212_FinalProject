using ThangNPHE151263_FinalProject.Models;
using Repositories;

namespace Services
{
    public class TableService
    {
        private TableRepository _repo;

        public List<Table> GetTableList()
        {
            _repo = new TableRepository();
            return _repo.GetAll();
        }

        public List<Table> GetTableByGroup(long idGroup)
        {
            _repo = new TableRepository();
            return _repo.GetTableByGroup(idGroup);
        }


    }
}
