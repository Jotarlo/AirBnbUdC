using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System.Collections.Generic;

namespace AirbnbUdc.Repository.Contracts.Contracts.Parameters
{
    public interface ICityRepository
    {
        CityDbModel CreateRecord(CityDbModel record);
        int DeleteRecord(int recordId);
        int UpdateRecord(CityDbModel record);
        CityDbModel GetRecord(int recordId);
        IEnumerable<CityDbModel> GetAllRecords(string filter);
        IEnumerable<CityDbModel> GetAllRecordsByCountryId(int countryId);
    }
}
