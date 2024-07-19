using System;
using System.Collections.Generic;
using ThangNPHE151263_FinalProject.Models;
using Repositories;

namespace Services
{
    public class BillService
    {
        private readonly BillRepository _billRepository;

        public BillService(BillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public List<Bill> GetAllBills()
        {
            return _billRepository.GetAllBills();
        }

        public Bill GetBillById(long id)
        {
            return _billRepository.GetBillById(id);
        }

        public bool AddBill(Bill billToAdd)
        {
            try
            {
                _billRepository.AddBill(billToAdd);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void UpdateBill(Bill bill)
        {
            _billRepository.UpdateBill(bill);
        }

        public void DeleteBill(long id)
        {
            _billRepository.DeleteBill(id);
        }
    }
}
