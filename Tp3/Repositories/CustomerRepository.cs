using System;
using Tp3.Models;

namespace Tp3.Repositories
{
    public class CustomerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CustomerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Customer> GetAllCustomers()
        {
            return _appDbContext.customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _appDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

        public void CreateCustomer(Customer customer)
        {
            _appDbContext.customers.Add(customer);
            _appDbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _appDbContext.customers.Update(customer);
            _appDbContext.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _appDbContext.customers.Remove(customer);
            _appDbContext.SaveChanges();
        }
    }
}
