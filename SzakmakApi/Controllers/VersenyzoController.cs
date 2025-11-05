using SzakmakApi.Models;
using SzakmakApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace SzakmakApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersenyzoController : Controller
    {

        private readonly versenyzoDbContext _context;

        public VersenyzoController(versenyzoDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<versenyzo>>> GetVersenyzok()
        {
            return _context.versenyzok.ToList();
        }
        [HttpPost]
        public async Task<ActionResult<versenyzo>> AddVersenyzo(versenyzo Versenyzo)
        {
            _context.versenyzok.Add(Versenyzo);
            await _context.SaveChangesAsync();
            return  Ok();
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
