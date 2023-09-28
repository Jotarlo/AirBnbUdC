namespace AirbnbUdC.Application.Contracts.DTO.Parameters
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CountryDTO Country { get; set; }

    }
}
