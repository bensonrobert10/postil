using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.BL
{
    public abstract class BLFactory
    {
        public static IManageParcel ManageParcel()
        {
            return new ManageParcelBL();
        }

    }
}
