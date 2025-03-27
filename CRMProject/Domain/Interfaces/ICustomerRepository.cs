using CRMProject.Domain.Entities;

namespace CRMProject.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllSync();
        Task<Customer> GetByIdSync(int id);
        Task AddSync(Customer customer);
        Task UpdateSync(Customer customer);
        Task DeleteSync(int id);
    }
}
