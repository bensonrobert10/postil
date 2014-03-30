using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.DAL
{
    public sealed class ParcelInfoDAL :DALBase, IParcelInfo 
    {
        private static ParcelInfoDAL instance;

        public static ParcelInfoDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ParcelInfoDAL();
                return instance;
            }
        }

        private ParcelInfoDAL()
        {
            connectionString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        public List<CountryDTO> GetAllFromCountry()
        {
            List<CountryDTO> lstCountry = new List<CountryDTO>
            {
              new CountryDTO { CountryId = 1, CountryName= "India"}
            };
            
            return lstCountry;
        }
    }
}
