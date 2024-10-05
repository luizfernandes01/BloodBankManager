using BloodBankManager.Models;
using BloodBankManager.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodBankManager.Controllers
{
    [Route("api/donors")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        private readonly BloodBankManagerDbContext _context;
        public DonorsController(BloodBankManagerDbContext context)
        {
            _context = context; 
        }

        [HttpGet]

        public IActionResult GetAll(string search = "" )
        {
            var donors = _context.Donors.ToList();

            return Ok(donors);

        }

        [HttpGet("ativos")]

        public IActionResult GetAllAtivo()
        {
            return Ok();
        }

        [HttpGet("inativos")]

        public IActionResult GetAllInativo()
        {
            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var donor = _context.Donors.SingleOrDefault(d => d.Id == id);

            return Ok(donor);
        }


        [HttpGet("{id}/todos-donatios")]

        public IActionResult GetById(string id)
        {
            return Ok();
        }


        [HttpPost]

        public IActionResult Post(CreateDonorInputModel model)
        {
            var donor = _context.Donors.ToList().First();

            _context.Donors.Add(donor);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById),new {id= 1},model);
        }


        [HttpPut("{id}")]

        public IActionResult Put(int id,UpdateDonorInputModel model)
        {
            var donor = _context.Donors.SingleOrDefault(d =>d.Id == id);

            if (donor == null)
            {
                return NotFound();
            }

            donor.Update(model.NomeCompleto,model.Genero,model.Peso,model.Endereco);

            _context.Donors.Update(donor);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}/ativado")]

        public IActionResult PutAtivado()
        {
            
 
            {
                return NoContent();
            }

          
        }


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var donor = _context.Donors.SingleOrDefault(d => d.Id == id);

            if (donor == null)
            {
                return NotFound();
            }

            
            _context.Donors.Update(donor);
            _context.SaveChanges();

            return NoContent();
        }
    }
}