using Introduction.Models;

namespace Introduction.DataTransferObjects
{
    public class TravelDTO
    {
        public int Id { get; set; }
        public DateTime TravelStartDate { get; set; }
        public DateTime? TravelEndDate { get; set; }
        public City? CityStart { get; set; }
        public City? CityEnd { get; set; }

        public List<TravelsPeopleDTO>? TravelsPeople { get; set; }
    }
}
