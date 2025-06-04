using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodApi.Models;

namespace FoodApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempUsersController : ControllerBase
    {
        private readonly NutritionDbContext _context;

        public TempUsersController(NutritionDbContext context)
        {
            _context = context;
        }

        // GET: api/TempUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TempUsers>>> GetTempUsers()
        {
            return await _context.TempUsers.ToListAsync();
        }

        // GET: api/TempUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TempUsers>> GetTempUsers(int id)
        {
            var tempUsers = await _context.TempUsers.FindAsync(id);

            if (tempUsers == null)
            {
                return NotFound();
            }

            return tempUsers;
        }

        // PUT: api/TempUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTempUsers(int id, TempUsers tempUsers)
        {
            if (id != tempUsers.id)
            {
                return BadRequest();
            }

            _context.Entry(tempUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TempUsersExists(id))
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

        // POST: api/TempUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TempUsers>> PostTempUsers(TempUsers tempUsers)
        {
            _context.TempUsers.Add(tempUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTempUsers", new { id = tempUsers.id }, tempUsers);
        }

        // DELETE: api/TempUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTempUsers(int id)
        {
            var tempUsers = await _context.TempUsers.FindAsync(id);
            if (tempUsers == null)
            {
                return NotFound();
            }

            _context.TempUsers.Remove(tempUsers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TempUsersExists(int id)
        {
            return _context.TempUsers.Any(e => e.id == id);
        }
    }
}
