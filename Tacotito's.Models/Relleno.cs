using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotito_s.Factory;

namespace Tacotito_s
{
    internal class Relleno : Ingrediente
    {
		private static int GlobalRellenoId = 0;
		private readonly int RellenoId = 0;
		public Relleno(string name, double precio)
        {
            Name = name;
            Precio_unitario = precio;
			GlobalRellenoId++;
			this.RellenoId = GlobalRellenoId;
		}

		public override string DatosIngrediente()
		{
			return $" Nro: {RellenoId} de {Name}, Precio: {Precio_unitario}";
		}
	}
}
