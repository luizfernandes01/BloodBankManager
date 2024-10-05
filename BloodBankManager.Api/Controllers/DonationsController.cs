

using BloodBankManager.Models;
using BloodBankManager.Persistence;

using Microsoft.AspNetCore.Mvc;

namespace BloodBankManager.Controllers
{
    [Route("api/donations")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private readonly BloodBankManagerDbContext _context;
        public DonationsController(BloodBankManagerDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()
        { 
            var donations = _context.Donations.ToList();

            return Ok(donations);
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var donation = _context.Donations.FirstOrDefault(d => d.Id == id);

            return Ok();
        }

        [HttpPost]

        public IActionResult Post(CreateDonationInputModel model)
        {
          

            return Ok();
        }
    }
}