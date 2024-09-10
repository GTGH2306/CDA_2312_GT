using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Introduction.Database;
using Introduction.Models;
using Microsoft.AspNetCore.Cors;
using Introduction.DataTransferObjects;

namespace Introduction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly CountriesDbContext _context;

        public PeopleController(CountriesDbContext context)
        {
            _context = context;
        }

        // GET: api/People
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
            var people = await _context.Person
                .Include(p => p.TravelsPeople).ThenInclude(t => t.Travel).ThenInclude(t => t.CityStart)
                .Include(p => p.TravelsPeople).ThenInclude(t => t.Travel).ThenInclude(t => t.CityEnd)
                .ToListAsync();
            
            List<PersonDTO> result = new List<PersonDTO>();
            foreach (Person _person in people)
            {
                result.Add(ToPersonDTO(_person));
            }
            return Ok(result);
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            var person = await _context.Person
                .Include(p => p.TravelsPeople).ThenInclude(t => t.Travel).ThenInclude(t => t.CityStart)
                .Include(p => p.TravelsPeople).ThenInclude(t => t.Travel).ThenInclude(t => t.CityEnd)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(ToPersonDTO(person));
        }

        // PUT: api/People/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Person>> PutPerson(int id, Person person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return person;
        }

        // POST: api/People
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }

        private static PersonDTO ToPersonDTO(Person _person)
        {
            
            List<TravelsPeopleDTO> travelsPeopleDTOs = new List<TravelsPeopleDTO>();
            foreach(TravelsPeople _tp in _person.TravelsPeople)
            {
                travelsPeopleDTOs.Add(
                    new TravelsPeopleDTO()
                    {
                        IsDriver = _tp.IsDriver,
                        Travel = new TravelDTO(){
                            Id = _tp.TravelId,
                            CityStart = _tp.Travel.CityStart,
                            CityEnd = _tp.Travel.CityEnd,
                            TravelStartDate = _tp.Travel.TravelStartDate,
                            TravelEndDate = _tp.Travel.TravelEndDate
                        }
                    });
            }
            PersonDTO dto = new PersonDTO()
            {
                Id = _person.Id,
                FirstName = _person.Firstname,
                LastName = _person.Lastname,
                TravelsPeople = travelsPeopleDTOs
            };

            return dto;
        }
    }
}
