using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotito_s.Factory;

namespace Tacotito_s
{
    internal class Taco
    {
        private static int TotalTacos = 1;
        private int myId;
        private readonly List<IIngrediente> IngredientesTaco = new();
        private readonly DateTime CreatedAt;
        public int MyId
        {
            get { return myId; }
        }

        public Taco(List<IIngrediente> lista)
        {
            CreatedAt = DateTime.Now;
			myId = TotalTacos;
			TotalTacos++;
			IngredientesTaco = lista;          
        }      

        public double Precio()
        {
            double PrecioTaco = 0;
            foreach (Ingrediente Ingred in IngredientesTaco.Cast<Ingrediente>())
            {
                PrecioTaco += Ingred.Precio_unitario;
            }
            return PrecioTaco;
        }
        public void PrecioToString()
        {
            double PrecioTaco = 0;
            foreach (Ingrediente Ingred in IngredientesTaco.Cast<Ingrediente>())
            {
                PrecioTaco += Ingred.Precio_unitario;
            }
            Console.WriteLine($"\nTotal a Pagar: {PrecioTaco,40}");
        }


		private void Ingredientes()
        {
            foreach (IIngrediente Ingrediente in IngredientesTaco)
            {
                Console.WriteLine(Ingrediente.ToString());
            }
        }
         public void InfoTaco ()
        {
			Console.WriteLine($"\nTaco Nro: {MyId}");			
            Console.WriteLine($"Creado: {CreatedAt,50:D}");
			Ingredientes();
            PrecioToString();
		}

    }
}
