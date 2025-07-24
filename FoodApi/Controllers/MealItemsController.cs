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
    public class MealItemsController : ControllerBase
    {
        private readonly NutritionDbContext _context;

        public MealItemsController(NutritionDbContext context)
        {
            _context = context;
        }

        // GET: api/MealItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MealItems>>> GetMealItems()
        {
            return await _context.MealItems.ToListAsync();
        }

        // GET: api/MealItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MealItems>> GetMealItems(int id)
        {
            var mealItems = await _context.MealItems.FindAsync(id);

            if (mealItems == null)
            {
                return NotFound();
            }

            return mealItems;
        }

        // GET: api/MealItems/meal/{mealId}
        [HttpGet("meal/{mealId}")]
        public async Task<ActionResult<IEnumerable<MealItems>>> GetMealItemsByMealId(int mealId)
        {
            var mealItems = await _context.MealItems.Where(mi => mi.MealId == mealId).ToListAsync();
            //if (mealItems == null || !mealItems.Any())
            //{
            //    return NotFound();
            //}
            return Ok(mealItems);
        }

        // PUT: api/MealItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealItems(int id, MealItems mealItems)
        {
            if (id != mealItems.Id)
            {
                return BadRequest();
            }

            _context.Entry(mealItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MealItemsExists(id))
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

        // POST: api/MealItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostMealItems([FromBody] List<MealItems> mealItems)
        {
            try
            {
                _context.MealItems.AddRange(mealItems);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Meal items added successfully." });
            }
            catch (Exception ex)
            {
                // Log error details to the console
                Console.WriteLine("Error saving meal items: " + ex.Message);
                return StatusCode(500, new { message = "An internal error occurred.", details = ex.Message });
            }
        }


        // DELETE: api/MealItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealItems(int id)
        {
            var mealItems = await _context.MealItems.FindAsync(id);
            if (mealItems == null)
            {
                return NotFound();
            }

            _context.MealItems.Remove(mealItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MealItemsExists(int id)
        {
            return _context.MealItems.Any(e => e.Id == id);
        }
    }
}
