using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_AR.GeneralClasses
{
    internal class clsFormat
    {
        public static string DateToShort( DateTime Dt1 )
        {
            return Dt1.ToString( "dd/MMM/yyyy" );
        }
    }
}
