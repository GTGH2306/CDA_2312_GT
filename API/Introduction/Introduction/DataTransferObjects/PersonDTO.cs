namespace Introduction.DataTransferObjects
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<TravelsPeopleDTO>? TravelsPeople { get; set; }
    }
}
