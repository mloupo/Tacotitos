using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotito_s.Factory;
using static Tacotito_s.Enums;

namespace Tacotito_s.Controllers
{
    public class IngredientController
    {
        private IngredientFactory fabrica = new IngredientFactory();
        public IngredientController() { }
        public IIngrediente Create(TipoIngrediente pProducto, string nombre, double precio)
        {
            IIngrediente creacion =fabrica.GetCreation(pProducto, nombre, precio);
            return creacion;
        }
    }
}
