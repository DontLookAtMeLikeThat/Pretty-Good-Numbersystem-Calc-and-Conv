using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberconverterT_este__r_
{
    static class Decimal
    {
        public static string ConvertToDec(string num, int fromBase, int toBase, bool IsCalculation)
        {
          
            return Convert.ToString(Convert.ToInt32(num, fromBase), toBase);
        }
    }
}
