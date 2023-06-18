using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Tacotito_s.Enums;

namespace Tacotito_s.Factory
{
    internal class FactoryIngrediente : IFactoryMethod
    {
       
        public FactoryIngrediente()
        {            
        }

        public IIngrediente GetCreation(TipoCreacion pProducto)
        {
            List<IIngrediente> listaIngredientes = new List<IIngrediente>();
            IIngrediente? producto = null;
            switch (pProducto)
            {
                case TipoCreacion.Salsa:
                    producto = new Salsa("Cheddar", 133.25);
                    listaIngredientes.Add(producto);
                    break;
                case TipoCreacion.Relleno:
                    producto = new Relleno("Maria Juana", 950.50);
                    listaIngredientes.Add(producto);
                    break;
                case TipoCreacion.Tortilla:
                    producto = new Tortilla("Arroz Integral", 122.50);
                    break;
            }
            return producto;
        }
    }
}
