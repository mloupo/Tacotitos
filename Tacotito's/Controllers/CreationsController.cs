using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotito_s.Factory;
using static Tacotito_s.Enums;

namespace Tacotito_s.Controllers
{
    internal class CreationsController
    {
        private FactoryIngrediente fabrica = new FactoryIngrediente();
        public CreationsController() { }
        public IIngrediente Create(TipoCreacion pProducto, string nombre, double precio)
        {
            IIngrediente creacion =fabrica.GetCreation(pProducto, nombre, precio);
            return creacion;
        }
    }
}
