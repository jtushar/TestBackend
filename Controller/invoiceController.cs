using Microsoft.AspNetCore.Mvc;
using BuggyApp.Data;
using BuggyApp.Models;
using System.Linq;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly DataContext _context;

        public InvoiceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInvoice()
        {
            var items = _context.Items.ToList();

            if (items.Any())
            {
                return Ok(new { items });
            }

            return NotFound("No invoice found");
        }
    }
}
