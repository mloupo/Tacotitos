﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s
{
    public static class Enums
    {  
        public enum TipoCreacion { Tortilla, Relleno, Salsa, Taco}
        

        [Flags]
        public enum Condimentos { nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8 }
        public enum Condimentos2        {
            nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8,
            Basica = Tomate | Lechuga,
            Completa = Tomate | Lechuga | Cebolla | Queso
        }        
    }
}