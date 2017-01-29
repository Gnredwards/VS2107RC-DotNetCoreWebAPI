using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebAPI.Models
{
    public interface ICustomerOrderHistoryContext
    {
        DbSet<CustomerOrderHistory> GetCustomerOrderHistory { get; set; }
    }
}