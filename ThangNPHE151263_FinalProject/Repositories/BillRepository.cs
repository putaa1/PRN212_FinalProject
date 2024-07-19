using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ThangNPHE151263_FinalProject.Models;

namespace Repositories
{
    public class BillRepository
    {
        private readonly MilkTeaContext _dbContext;

        public BillRepository(MilkTeaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Bill> GetAllBills()
        {
            return _dbContext.Bills.ToList();
        }

        public Bill GetBillById(long id)
        {
            return _dbContext.Bills.FirstOrDefault(b => b.Id == id);
        }

        public void AddBill(Bill bill)
        {
            _dbContext.Bills.Add(bill);
            _dbContext.SaveChanges();
        }

        public void UpdateBill(Bill bill)
        {
            _dbContext.Entry(bill).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteBill(long id)
        {
            var bill = _dbContext.Bills.FirstOrDefault(b => b.Id == id);
            if (bill != null)
            {
                _dbContext.Bills.Remove(bill);
                _dbContext.SaveChanges();
            }
        }
    }
}
