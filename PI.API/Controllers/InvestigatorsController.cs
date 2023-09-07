using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PI.API.Data;
using PI.Shared.Entities;

namespace PI.API.Controllers
{

    [ApiController]
    [Route("api/investigators")]
    public class InvestigatorsController : ControllerBase
    {

        private readonly DataContext _context;
        public InvestigatorsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task <IActionResult> Get()
        {
            return Ok(await _context.Investigators.ToListAsync());    
        }

        [HttpPost]
        public async Task <ActionResult> Post(Investigator investigator)
        {
            _context.Add(investigator);
                await _context.SaveChangesAsync();
            return Ok(investigator);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var investigator=await 
                _context.Investigators.FirstOrDefaultAsync(x => x.Id == Id);
            if (investigator == null)
            {
                return NotFound();
            }
            return Ok(investigator);
        }



    }
}
