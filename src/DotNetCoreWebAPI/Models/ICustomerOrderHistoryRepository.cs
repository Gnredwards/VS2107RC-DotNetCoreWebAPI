using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Models
{
    public interface ICustomerOrderHistoryRepository
    {
        Task<IEnumerable<CustomerOrderHistory>> GetAsync(string CustomerID);
    }
}
