using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tacotito_s.Enums;
using Tacotito_s.Factory;

namespace Tacotito_s.Controllers
{
	public class TacoController
	{
		public TacoController() { }
		private Taco taco;
		public Taco Create(List<IIngrediente> lista)
		{
			taco = new Taco(lista);
			return taco;
		}
	}
}
