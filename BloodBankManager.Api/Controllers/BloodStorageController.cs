using BloodBankManager.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankManager.Controllers
{
    [Route("api/blood-storages")]
    [ApiController]
    public class BloodStorageController : ControllerBase
    {
        private readonly BloodBankManagerDbContext _context;
        public BloodStorageController(BloodBankManagerDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IActionResult GetAll()
        {
            var bloodStorages = _context.BloodStorages.ToList();    
                 
            return Ok(bloodStorages);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var bloodStorage = _context.BloodStorages.FirstOrDefault(b => b.Id == id);

            return Ok(bloodStorage);
        }
    }
}
