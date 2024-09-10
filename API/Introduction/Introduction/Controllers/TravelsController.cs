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
    public class TravelsController : ControllerBase
    {
        private readonly CountriesDbContext _context;

        public TravelsController(CountriesDbContext context)
        {
            _context = context;
        }

        // GET: api/Travels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Travel>>> GetTravels()
        {
             var travels = await _context.Travels
                .Include(t => t.CityStart)
                .Include(t => t.CityEnd)
                .Include(t => t.TravelsPeople).ThenInclude(t => t.Person)
                .ToListAsync();

            List<TravelDTO> result = new List<TravelDTO>();
            foreach (Travel _travel in travels)
            {
                result.Add(ToTravelDTO(_travel));
            }
            return Ok(result);
        }

        // GET: api/Travels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Travel>> GetTravel(int id)
        {
            var travel = await _context.Travels
                .Include(t => t.CityStart)
                .Include(t => t.CityEnd)
                .Include(t => t.TravelsPeople).ThenInclude(t => t.Person)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (travel == null)
            {
                return NotFound();
            }

            return Ok(ToTravelDTO(travel));
        }

        // PUT: api/Travels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravel(int id, Travel travel)
        {
            if (id != travel.Id)
            {
                return BadRequest();
            }

            _context.Entry(travel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelExists(id))
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

        // POST: api/Travels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Travel>> PostTravel(Travel travel)
        {
            _context.Travels.Add(travel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravel", new { id = travel.Id }, travel);
        }

        // DELETE: api/Travels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravel(int id)
        {
            var travel = await _context.Travels.FindAsync(id);
            if (travel == null)
            {
                return NotFound();
            }

            _context.Travels.Remove(travel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravelExists(int id)
        {
            return _context.Travels.Any(e => e.Id == id);
        }

        private TravelDTO ToTravelDTO(Travel _travel)
        {
            List<TravelsPeopleDTO> travelsPeopleDTOs = new List<TravelsPeopleDTO>();
            if (_travel.TravelsPeople != null)
            {
                foreach (TravelsPeople _tp in _travel.TravelsPeople)
                {
                    travelsPeopleDTOs.Add(
                        new TravelsPeopleDTO()
                        {
                            IsDriver = _tp.IsDriver,
                            Person = new PersonDTO()
                            {
                                Id = _tp.PersonId,
                                FirstName = _tp.Person.Firstname,
                                LastName = _tp.Person.Lastname
                            }
                        }
                    );
                }
            }
            TravelDTO dTO = new TravelDTO()
            {
                Id = _travel.Id,
                CityStart = _travel.CityStart,
                CityEnd = _travel.CityEnd,
                TravelStartDate = _travel.TravelStartDate,
                TravelEndDate = _travel.TravelEndDate,
                TravelsPeople = travelsPeopleDTOs
            };
            return dTO;
        }
    }
}
