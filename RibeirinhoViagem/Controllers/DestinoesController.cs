using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RibeirinhoViagem.DtCont;
using RibeirinhoViagem.Model;

namespace RibeirinhoViagem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoesController : ControllerBase
    {
        private readonly DbContextMod5 _context;

        public DestinoesController(DbContextMod5 context)
        {
            _context = context;
        }

        // GET: api/Destinoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destino>>> GetDestino()
        {
            return await _context.Destino.ToListAsync();
        }

        // GET: api/Destinoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destino>> GetDestino(string id)
        {
            var destino = await _context.Destino.FindAsync(id);

            if (destino == null)
            {
                return NotFound();
            }

            return destino;
        }

        // PUT: api/Destinoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestino(string id, Destino destino)
        {
            if (id != destino.CidadeDestino)
            {
                return BadRequest();
            }

            _context.Entry(destino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Destinoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destino>> PostDestino(Destino destino)
        {
            _context.Destino.Add(destino);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DestinoExists(destino.CidadeDestino))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDestino", new { id = destino.CidadeDestino }, destino);
        }

        // DELETE: api/Destinoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestino(string id)
        {
            var destino = await _context.Destino.FindAsync(id);
            if (destino == null)
            {
                return NotFound();
            }

            _context.Destino.Remove(destino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinoExists(string id)
        {
            return _context.Destino.Any(e => e.CidadeDestino == id);
        }
    }
}
