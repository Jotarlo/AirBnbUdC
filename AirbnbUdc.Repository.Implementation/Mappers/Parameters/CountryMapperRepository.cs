using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using System.Collections.Generic;
using System.Linq;

namespace AirbnbUdc.Repository.Implementation.Mappers.Parameters
{
    public class CountryMapperRepository : BaseMapperRepository<Country, CountryDbModel>
    {
        public override CountryDbModel MapperT1toT2(Country input)
        {
            return new CountryDbModel
            {
                Id = input.Id,
                Name = input.CountryName
            };
        }

        public override IEnumerable<CountryDbModel> MapperT1toT2(IEnumerable<Country> input)
        {
            IList<CountryDbModel> list = new List<CountryDbModel>();
            foreach (var item in input)
            {
                list.Add(MapperT1toT2(item));
            }
            return list;
        }

        public override Country MapperT2toT1(CountryDbModel input)
        {
            return new Country
            {
                Id = input.Id,
                CountryName = input.Name
            };
        }

        public override IEnumerable<Country> MapperT2toT1(IEnumerable<CountryDbModel> input)
        {
            IList<Country> list = new List<Country>();
            foreach (var item in input)
            {
                list.Add(MapperT2toT1(item));
            }
            return list;
        }
    }
}
