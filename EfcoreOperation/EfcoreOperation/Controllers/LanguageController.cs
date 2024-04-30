using EfcoreOperation.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Identity.Client;
using System.Threading.Tasks;

namespace EfcoreOperation.Controllers
{
    [Route("api/GetLanguage")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _appdbcontext;
        public LanguageController(AppDbContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetLanguage()
        {
            var result=await _appdbcontext.Languages.ToListAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLanguageById([FromRoute]int id)
        {
            var result = await _appdbcontext.Languages.FindAsync(id);
            return Ok(result);
        }
    }
}
