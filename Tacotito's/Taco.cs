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
        private static int ID = 0;
        private int myId = 0;
        private List<IIngrediente> IngredientesTaco = new List<IIngrediente>();

        public int MyId
        {
            get { return myId; }
        }

        public Taco(List<IIngrediente> lista)
        {
            ID++;
            this.myId = ID;
            IngredientesTaco = lista;          
        }      

        public double Precio()
        {
            double PrecioTaco = 0;
            foreach (Ingrediente Ingred in IngredientesTaco)
            {
                PrecioTaco += Ingred.Precio_unitario;
            }
            return PrecioTaco;
        }
        public void PrecioToString()
        {
            double PrecioTaco = 0;
            foreach (Ingrediente Ingred in IngredientesTaco)
            {
                PrecioTaco += Ingred.Precio_unitario;
            }
            Console.WriteLine(PrecioTaco);
        }

        public void Ingredientes()
        {
            foreach (IIngrediente Ingrediente in IngredientesTaco)
            {
                Console.WriteLine(Ingrediente.ToString());
            }
        }


    }
}
