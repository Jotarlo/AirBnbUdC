namespace AirbnbUdc.Repository.Contracts.DbModel.Parameters
{
    public class CityDbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CountryDbModel Country { get; set; }
    }
}
