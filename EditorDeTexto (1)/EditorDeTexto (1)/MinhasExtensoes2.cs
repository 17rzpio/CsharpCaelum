using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasExtensoes2
{
    public static class StringExtensions
    {
        public static string Pluralize(this string texto)
        {
            if (texto.EndsWith("s"))
            {
                return texto;
            }
            else
            {
                return texto + "s";
            }
        }
    }
}
