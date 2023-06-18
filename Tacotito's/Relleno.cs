using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s
{
    internal class Relleno : Ingrediente
    {
        public Relleno(string name, double precio)
        {
            Name = name;
            Precio_unitario = precio;
        }
       
    }
}
