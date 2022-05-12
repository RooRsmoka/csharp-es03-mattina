using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class Borsellino
    {
        static int iTotale = 0;
        internal static int Add(int iValore)
        {
            iTotale = iTotale + iValore;
            return iTotale;
        }
    }
}
