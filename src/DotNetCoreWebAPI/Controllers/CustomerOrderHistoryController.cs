using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerOrderHistoryController : Controller
    {
        public ICustomerOrderHistoryRepository CustomerOrderHistory;
        public CustomerOrderHistoryController(ICustomerOrderHistoryRepository customerOrderHistoryRepository)
        {
            CustomerOrderHistory = customerOrderHistoryRepository;
        }
  
        // GET: api/CustomerOrderHistory/customerID
        [HttpGet("{id}", Name ="GetOrderHistory")]
        public IActionResult Get(string id)
        {
            var item = CustomerOrderHistory.GetAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
