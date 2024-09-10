using Introduction.Models;

namespace Introduction.DataTransferObjects
{
    public class TravelsPeopleDTO
    {
        public TravelDTO? Travel { get; set; }
        public PersonDTO? Person { get; set; }

        public bool IsDriver { get; set; }
    }
}
