using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Introduction.Database;
using Introduction.Models;
using Introduction.DataTransferObjects;

namespace Introduction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsPeoplesController : ControllerBase
    {
        private readonly CountriesDbContext _context;

        public TravelsPeoplesController(CountriesDbContext context)
        {
            _context = context;
        }

        // GET: api/TravelsPeoples
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelsPeople>>> GetTravelsPeople()
        {
            var travelsPeople = await _context.TravelsPeople
                .Include(t => t.Travel).ThenInclude(t => t.CityStart)
                .Include(t => t.Travel).ThenInclude( t => t.CityEnd)
                .Include(t => t.Person).ToListAsync();
            
            List<TravelsPeopleDTO> dTOs = new List<TravelsPeopleDTO>();

            foreach(TravelsPeople _travelPeople in travelsPeople)
            {
                dTOs.Add(ToTravelsPeopleDTO(_travelPeople));
            }

            return Ok(dTOs);
        }

        // GET: api/TravelsPeoples/5
        [HttpGet("{id1}-{id2}")]
        public async Task<ActionResult<TravelsPeople>> GetTravelsPeople(int id1, int id2)
        {
            var travelsPeople = await _context.TravelsPeople.
                Include(t => t.Travel).ThenInclude(t => t.CityStart)
                .Include(t => t.Travel).ThenInclude(t => t.CityEnd)
                .Include(t => t.Person)
                .FirstOrDefaultAsync(tp => tp.TravelId == id1 && tp.PersonId == id2);

            if (travelsPeople == null)
            {
                return NotFound();
            }

            return Ok(ToTravelsPeopleDTO(travelsPeople));
        }

        // PUT: api/TravelsPeoples/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravelsPeople(int id, TravelsPeople travelsPeople)
        {
            if (id != travelsPeople.TravelId)
            {
                return BadRequest();
            }

            _context.Entry(travelsPeople).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelsPeopleExists(id))
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

        // POST: api/TravelsPeoples
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TravelsPeople>> PostTravelsPeople(TravelsPeople travelsPeople)
        {
            _context.TravelsPeople.Add(travelsPeople);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TravelsPeopleExists(travelsPeople.TravelId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTravelsPeople", new { id = travelsPeople.TravelId }, travelsPeople);
        }

        // DELETE: api/TravelsPeoples/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravelsPeople(int id)
        {
            var travelsPeople = await _context.TravelsPeople.FindAsync(id);
            if (travelsPeople == null)
            {
                return NotFound();
            }

            _context.TravelsPeople.Remove(travelsPeople);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravelsPeopleExists(int id)
        {
            return _context.TravelsPeople.Any(e => e.TravelId == id);
        }

        private TravelsPeopleDTO ToTravelsPeopleDTO(TravelsPeople _travelsPeople)
        {
            TravelsPeopleDTO dTO = new TravelsPeopleDTO();
            dTO.IsDriver = _travelsPeople.IsDriver;
            dTO.Person = new PersonDTO()
            {
                Id = _travelsPeople.PersonId,
                FirstName = _travelsPeople.Person.Firstname,
                LastName = _travelsPeople.Person.Lastname
            };
            dTO.Travel = new TravelDTO()
            {
                Id = _travelsPeople.TravelId,
                CityStart = _travelsPeople.Travel.CityStart,
                CityEnd = _travelsPeople.Travel.CityEnd,
                TravelStartDate = _travelsPeople.Travel.TravelStartDate,
                TravelEndDate = _travelsPeople.Travel.TravelEndDate
            };

            return dTO;
        }
    }
}
