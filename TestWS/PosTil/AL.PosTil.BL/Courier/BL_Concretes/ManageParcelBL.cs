using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.BL
{
    public class ManageParcelBL : IManageParcel
    {
        public ManageParcelBL()
        {

        }

       public List<AL.PosTil.DAL.CountryDTO> LoadCountries(ref AL.PosTil.BL.Utils.PosTilStatus outputStatus)
       {
           try
           {
               outputStatus.Status = PosTil.BL.Utils.PosTilStatusType.Success;
               return AL.PosTil.DAL.DALFactory.GetParcelInfoDAL().GetAllFromCountry();
           }
           catch(Exception ex)
           {
              outputStatus.Status = PosTil.BL.Utils.PosTilStatusType.Error;
              outputStatus.Message = ex.ToString();
              Utils.WriteErrorLog(ex);
              return null;
           }
       }
    }
}
