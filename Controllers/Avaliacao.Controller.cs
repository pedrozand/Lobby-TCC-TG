using DataBaseAPI.Db;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AvaliacaoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public AvaliacaoController(DataBaseContext context)
        {
            _context = context;
        }

     [HttpGet]
        public async Task<ActionResult<IEnumerable<Avaliacao>>> GetComentarios()
        {
          if (_context.Avaliacoes == null)
          {
              return NotFound();
          }
            return await _context.Avaliacoes.ToListAsync();
        }




        [HttpPost]
        public async Task<IActionResult> AdicionarAvaliacao([FromBody] Avaliacao avaliacao)
        {
            // Verifique se o usuário já avaliou a quadra
            var avaliacaoExistente = await _context.Avaliacoes
                .FirstOrDefaultAsync(a => a.IdUsuario == avaliacao.IdUsuario && a.IdQuadra == avaliacao.IdQuadra);

            if (avaliacaoExistente != null)
            {
                // Usuário já avaliou esta quadra; você pode tratar isso de acordo com sua lógica.
                return BadRequest("Você já avaliou esta quadra.");
            }

            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();
            return Ok("Avaliação adicionada com sucesso.");
        }

        [HttpGet("media/{idQuadra}")]
        public async Task<IActionResult> CalcularMedia(int idQuadra)
        {
            var media = await _context.Avaliacoes
                .Where(a => a.IdQuadra == idQuadra)
                .AverageAsync(a => a.Nota);

            return Ok(media);
        }
    }
}
