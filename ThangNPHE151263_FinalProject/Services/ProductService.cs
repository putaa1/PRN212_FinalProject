using ThangNPHE151263_FinalProject.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        private IGenericRepository<Product> _genericRepository = null;
        public ProductService()
        {
            this._genericRepository = new GenericRepository<Product>();
        }
        public List<Product> GetAllProductList()
        {
            return (List<Product>)_genericRepository.GetAll();
        }
    }
}
