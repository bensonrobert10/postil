using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.BL
{
    public interface IManageParcel
    {
        List<AL.PosTil.DAL.CountryDTO> LoadCountries(ref AL.PosTil.BL.Utils.PosTilStatus outputStatus);
    }
}
