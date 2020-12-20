using System;
using System.Threading.Tasks;

namespace Quality.DTH.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer Add(Customer buyer);
        Customer Update(Customer buyer);
        Task<Customer> FindAsync(Int64 Id);
    }
}