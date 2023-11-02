using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using System.Collections.Generic;

namespace AirbnbUdc.Repository.Implementation.Mappers.Parameters
{
    public class CityMapperRepository : BaseMapperRepository<City, CityDbModel>
    {
        public override CityDbModel MapperT1toT2(City input)
        {
            CountryMapperRepository countryMapper = new CountryMapperRepository();
            return new CityDbModel
            {
                Id = input.Id,
                Name = input.CityName,
                Country = countryMapper.MapperT1toT2(input.Country)
            };
        }

        public override IEnumerable<CityDbModel> MapperT1toT2(IEnumerable<City> input)
        {
            IList<CityDbModel> list = new List<CityDbModel>();
            foreach (var item in input)
            {
                list.Add(MapperT1toT2(item));
            }
            return list;
        }

        public override City MapperT2toT1(CityDbModel input)
        {
            return new City
            {
                Id = input.Id,
                CityName = input.Name,
                CountryId = input.Country.Id
            };
        }

        public override IEnumerable<City> MapperT2toT1(IEnumerable<CityDbModel> input)
        {
            IList<City> list = new List<City>();
            foreach (var item in input)
            {
                list.Add(MapperT2toT1(item));
            }
            return list;
        }
    }
}
