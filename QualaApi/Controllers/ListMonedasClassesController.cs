using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QualaApi.Data;
using QualaApi.Models;

namespace QualaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListMonedasClassesController : ControllerBase
    {
        private readonly QualaApiContext _context;

        public ListMonedasClassesController(QualaApiContext context)
        {
            _context = context;
        }

        // GET: api/ListMonedasClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListMonedasClass>>> GetListMonedasClass()
        {
          if (_context.ListMonedasClass == null)
          {
              return NotFound();
          }
            return await _context.ListMonedasClass.ToListAsync();
        }

        // GET: api/ListMonedasClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListMonedasClass>> GetListMonedasClass(int id)
        {
          if (_context.ListMonedasClass == null)
          {
              return NotFound();
          }
            var listMonedasClass = await _context.ListMonedasClass.FindAsync(id);

            if (listMonedasClass == null)
            {
                return NotFound();
            }

            return listMonedasClass;
        }

        // PUT: api/ListMonedasClasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListMonedasClass(int id, ListMonedasClass listMonedasClass)
        {
            if (id != listMonedasClass.Id)
            {
                return BadRequest();
            }

            _context.Entry(listMonedasClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListMonedasClassExists(id))
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

        // POST: api/ListMonedasClasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListMonedasClass>> PostListMonedasClass(ListMonedasClass listMonedasClass)
        {
          if (_context.ListMonedasClass == null)
          {
              return Problem("Entity set 'QualaApiContext.ListMonedasClass'  is null.");
          }
            _context.ListMonedasClass.Add(listMonedasClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListMonedasClass", new { id = listMonedasClass.Id }, listMonedasClass);
        }

        // DELETE: api/ListMonedasClasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListMonedasClass(int id)
        {
            if (_context.ListMonedasClass == null)
            {
                return NotFound();
            }
            var listMonedasClass = await _context.ListMonedasClass.FindAsync(id);
            if (listMonedasClass == null)
            {
                return NotFound();
            }

            _context.ListMonedasClass.Remove(listMonedasClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListMonedasClassExists(int id)
        {
            return (_context.ListMonedasClass?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
