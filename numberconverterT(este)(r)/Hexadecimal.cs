using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberconverterT_este__r_
{
    static class Hexadecimal
    {
        public static string ConvertToHex(string num, int fromBase, int toBase)
        {
          
            return Convert.ToString(Convert.ToInt32(num, fromBase), toBase);
        }
    }
}
