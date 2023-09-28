using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System.Collections.Generic;

namespace AirbnbUdc.Repository.Contracts.Contracts.Parameters
{
    public interface ICountryRepository
    {
        CountryDbModel CreateRecord(CountryDbModel record);
        int DeleteRecord(int recordId);
        int UpdateRecord(CountryDbModel record);
        CountryDbModel GetRecord(int recordId);
        IEnumerable<CountryDbModel> GetAllRecords(string filter);

    }
}
