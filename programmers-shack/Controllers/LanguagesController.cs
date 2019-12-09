using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using programmers_shack.Data;

namespace programmers_shack.Controllers
{
    [Route("lg/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private DataContext _context;
        public LanguagesController(DataContext context){
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetLanguages(){
            var lgs = await _context.Languages.ToListAsync();
            return Ok(lgs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLanguage(int id){
            var lg = await _context.Languages.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(lg);
        }
    }
}