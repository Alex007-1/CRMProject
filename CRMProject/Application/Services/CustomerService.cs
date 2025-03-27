using CRMProject.Domain.Entities;
using CRMProject.Domain.Interfaces;

namespace CRMProject.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _repository.GetAllSync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _repository.GetByIdSync(id);
        }

        public async Task CreateCustomer(Customer customer)
        {
            await _repository.AddSync(customer);
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            await _repository.UpdateSync(customer);
        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _repository.DeleteSync(id);
        }
    }
}
