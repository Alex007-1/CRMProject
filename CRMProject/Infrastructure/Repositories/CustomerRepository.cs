using CRMProject.Domain.Entities;
using CRMProject.Domain.Interfaces;
using CRMProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CRMProject.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllSync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdSync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task AddSync(Customer customer)
        {
            _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSync(Customer customer)
        {
           var local = _context.Customers.Local.FirstOrDefault(c =>c.AccountId == customer.AccountId);
            if (local != null)
            {
                _context.Entry(local).CurrentValues.SetValues(customer);
            }
            else
            {
                _context.Customers.Update(customer);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSync(int id)
        {
            var customer = await GetByIdSync(id);
            if (customer != null)//validation
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
