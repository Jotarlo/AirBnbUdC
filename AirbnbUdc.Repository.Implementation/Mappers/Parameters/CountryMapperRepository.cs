using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using System.Collections.Generic;

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
            foreach (var item in input)
            {
                yield return MapperT1toT2(item);
            }
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
            foreach (var item in input)
            {
                yield return MapperT2toT1(item);
            }
        }
    }
}
