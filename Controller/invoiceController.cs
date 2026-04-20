using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {
            // Example invoice items
            List<Item> items = new List<Item>
            {
                new Item { name = "Laptop", price = 1200.50 },
                new Item { name = "Mouse", price = 25.75 }
            };

            if (items.Count > 0)
            {
                return Ok(new { items });
            }

            return NotFound("No invoice found");
        }

        public class Item
        {
            public string name { get; set; }
            public double price { get; set; }
        }
    }
}
