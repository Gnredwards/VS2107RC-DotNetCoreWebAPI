using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;


namespace DotNetCoreWebAPI.Models
{
    public class CustomerOrderHistoryRepository : ICustomerOrderHistoryRepository
    {
        public ICustomerOrderHistoryContext _customerOrderHistoryContext { get; set; }

        public CustomerOrderHistoryRepository(CustomerOrderHistoryContext customerOrderHistoryContext)
        {
            _customerOrderHistoryContext = customerOrderHistoryContext;
        }
        public async Task<IEnumerable<CustomerOrderHistory>> GetAsync(string CustomerID)
        {
            SqlParameter param1 = new SqlParameter("@CustomerID",
                   SqlDbType.NChar, 5)
            {
                Value = CustomerID
            };
            
            return await _customerOrderHistoryContext.GetCustomerOrderHistory.FromSql("CustOrderHist @CustomerID",
                param1).ToListAsync();

        }
    }
}
