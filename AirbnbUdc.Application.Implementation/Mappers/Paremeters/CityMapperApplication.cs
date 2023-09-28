using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System.Collections.Generic;

namespace AirbnbUdc.Application.Implementation.Mappers.Paremeters
{
    public class CityMapperApplication : MapperBaseApplication<CityDbModel, CityDTO>
    {
        public override CityDTO MapperT1toT2(CityDbModel input)
        {
            CountryMapperApplication countryMapper = new CountryMapperApplication();
            return new CityDTO
            {
                Id = input.Id,
                Name = input.Name,
                Country = countryMapper.MapperT1toT2(input.Country)
            };
        }

        public override IEnumerable<CityDTO> MapperT1toT2(IEnumerable<CityDbModel> input)
        {
            foreach (var item in input)
            {
                yield return MapperT1toT2(item);
            }
        }

        public override CityDbModel MapperT2toT1(CityDTO input)
        {
            CountryMapperApplication countryMapper = new CountryMapperApplication();
            return new CityDbModel
            {
                Id = input.Id,
                Name = input.Name,
                Country = countryMapper.MapperT2toT1(input.Country)
            };
        }

        public override IEnumerable<CityDbModel> MapperT2toT1(IEnumerable<CityDTO> input)
        {
            foreach (var item in input)
            {
                yield return MapperT2toT1(item);
            }
        }
    }
}
