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
        public IIngrediente GetCreation(TipoCreacion pProducto, string nombre, double precio)
        {
            List<IIngrediente> listaIngredientes = new List<IIngrediente>();
            IIngrediente? producto = null;
            switch (pProducto)
            {
                case TipoCreacion.Salsa:
                    producto = new Salsa(nombre, precio);
                    listaIngredientes.Add(producto);
                    break;
                case TipoCreacion.Relleno:
                    producto = new Relleno(nombre, precio);
                    listaIngredientes.Add(producto);
                    break;
                case TipoCreacion.Tortilla:
                    producto = new Tortilla(nombre, precio);
                    break;
            }
            return producto;
        }
    }
}
