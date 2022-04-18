using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG1
{
    static class IntegerExtension
    {
        public static int BitAt(this int @this, int bit) => (@this & (1 << bit)) >> bit;
    }
}
