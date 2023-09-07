using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PI.API.Data;
using PI.Shared.Entities;

namespace PI.API.Controllers
{

    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProjectsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Project project)
        {
            _context.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var project = await
                _context.Projects.FirstOrDefaultAsync(x => x.Id == Id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
    }
}
