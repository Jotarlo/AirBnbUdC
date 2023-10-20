using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirBnbUdC.GUI.Models.Parameters;
using System;
using System.Collections.Generic;

namespace AirBnbUdC.GUI.Mappers.Parameters
{
    public class CityMapperGUI : MapperBaseGUI<CityDTO, CityModel>
    {
        public override CityModel MapperT1toT2(CityDTO input)
        {
            CountryMapperGUI countryMapper = new CountryMapperGUI();
            return new CityModel
            {
                Id = input.Id,
                Name = input.Name,
                Country = countryMapper.MapperT1toT2(input.Country)
            };
        }

        public override IEnumerable<CityModel> MapperT1toT2(IEnumerable<CityDTO> input)
        {
            foreach (var item in input)
            {
                yield return MapperT1toT2(item);
            }
        }

        public override CityDTO MapperT2toT1(CityModel input)
        {
            CountryMapperGUI countryMapper = new CountryMapperGUI();

            return new CityDTO
            {
                Id = input.Id,
                Name = input.Name,
            Country = countryMapper.MapperT2toT1(input.Country)
            };
        }

        public override IEnumerable<CityDTO> MapperT2toT1(IEnumerable<CityModel> input)
        {
            foreach (var item in input)
            {
                yield return MapperT2toT1(item);
            }
        }
    }
}