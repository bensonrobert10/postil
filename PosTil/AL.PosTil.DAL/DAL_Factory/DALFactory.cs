using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.DAL
{
    public abstract class DALFactory
    {
        public static IParcelInfo GetParcelInfoDAL()
        {
            return ParcelInfoDAL.Instance;
        }
    }
}
