using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using AirbnbUdc.Repository.Implementation.Mappers.Parameters;
using System.Collections.Generic;
using System.Linq;

namespace AirbnbUdc.Repository.Implementation.Implementation.Parameters
{
    public class CountryImplementationRepository : ICountryRepository
    {
        public CountryDbModel CreateRecord(CountryDbModel record)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    if (db.Country.Where(x => x.CountryName.Equals(record.Name)).Count() == 0)
                    {
                        CountryMapperRepository mapper = new CountryMapperRepository();
                        Country dbRecord = mapper.MapperT2toT1(record);
                        db.Country.Add(dbRecord);
                        db.SaveChanges();
                        record.Id = dbRecord.Id;
                    }
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
            return record;
        }

        public int DeleteRecord(int recordId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CountryDbModel> GetAllRecords()
        {
            throw new System.NotImplementedException();
        }

        public CountryDbModel GetRecord(int recordId)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateRecord(CountryDbModel record)
        {
            throw new System.NotImplementedException();
        }
    }
}
