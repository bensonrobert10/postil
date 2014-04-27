using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.DAL
{
    public interface IParcelInfo
    {
        List<CountryDTO> GetAllFromCountry();
    }
}
