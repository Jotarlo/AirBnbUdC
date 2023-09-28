using AirbnbUdc.Application.Implementation.Mappers.Paremeters;
using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.Implementation.Parameters;
using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System;
using System.Collections.Generic;

namespace AirbnbUdc.Application.Implementation.Implementation.Parameters
{
    public class CityImplementationApplication : ICityApplication
    {
        ICityRepository _countryRepository;

        public CityImplementationApplication() { 
            this._countryRepository = new CityImplementationRepository();
        }

        /// <summary>
        /// Método que crea un registro en la tabla City
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public CityDTO CreateRecord(CityDTO record)
        {
            CityMapperApplication mapper = new CityMapperApplication();
            CityDbModel mapped = mapper.MapperT2toT1(record);
            CityDbModel created = this._countryRepository.CreateRecord(mapped);
            return mapper.MapperT1toT2(created);
        }

        /// <summary>
        /// Método que elimina un registro de la tabla City
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public int DeleteRecord(int recordId)
        {
            int deleted = this._countryRepository.DeleteRecord(recordId);
            return deleted;
        }

        /// <summary>
        /// Método que obtiene todos los registros de la tabla City
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public IEnumerable<CityDTO> GetAllRecords(string filter)
        {
            CityMapperApplication mapper = new CityMapperApplication();
            IEnumerable<CityDbModel> records = this._countryRepository.GetAllRecords(filter);
            return mapper.MapperT1toT2(records);
        }

        /// <summary>
        /// Método que obtiene todos los registros de la tabla City por CountryId
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        public IEnumerable<CityDTO> GetAllRecordsByCountryId(int countryId)
        {
            CityMapperApplication mapper = new CityMapperApplication();
            IEnumerable<CityDbModel> records = this._countryRepository.GetAllRecordsByCountryId(countryId);
            return mapper.MapperT1toT2(records);
        }

        /// <summary>
        /// Método que obtiene un registro de la tabla City
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public CityDTO GetRecord(int recordId)
        {
            CityMapperApplication mapper = new CityMapperApplication();
            CityDbModel record = this._countryRepository.GetRecord(recordId);
            return mapper.MapperT1toT2(record);
        }


        /// <summary>
        /// Método que actualiza un registro de la tabla City
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int UpdateRecord(CityDTO record)
        {
            CityMapperApplication mapper = new CityMapperApplication();
            CityDbModel mapped = mapper.MapperT2toT1(record);
            int updated = this._countryRepository.UpdateRecord(mapped);
            return updated;
        }
    }
}
