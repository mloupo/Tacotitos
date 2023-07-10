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
    public class IngredientFactory
    {
		public IIngrediente GetCreation(TipoIngrediente pProducto, string nombre, double precio)
        {
            List<IIngrediente> listaIngredientes = new List<IIngrediente>();
            IIngrediente? producto = null;
            switch (pProducto)
            {
                case TipoIngrediente.Salsa:
                    producto = new Salsa(nombre, precio);
                    listaIngredientes.Add(producto);
                    break;
                case TipoIngrediente.Relleno:
                    producto = new Relleno(nombre, precio);
                    listaIngredientes.Add(producto);
                    break;
                case TipoIngrediente.Tortilla:
                    producto = new Tortilla(nombre, precio);
                    break;
            }
            return producto;
        }	
	}
}
