using ThangNPHE151263_FinalProject.Models;
using Repositories;

namespace Services
{
    public class TableGroupService
    {
        private TableGroupRepository _repo;

        public List<GroupTable> GetTableGroupList()
        {
            _repo = new TableGroupRepository();
            return _repo.GetAll();
        }

    }
}
