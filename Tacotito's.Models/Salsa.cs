using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s
{
    internal class Salsa : Ingrediente 
    {
		private static int GlobalSalsaId = 0;
		private readonly int SalsaId = 0;
		public Salsa(string name, double precio) 
        {          
            Name = name;
            Precio_unitario=precio;
			GlobalSalsaId++;
			this.SalsaId = GlobalSalsaId;
		}

		public override string DatosIngrediente()
		{
			return $" Nro: {SalsaId} de {Name}, Precio: {Precio_unitario}";
		}
	}
}
