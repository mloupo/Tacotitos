using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Tacotito_s.Enums;

namespace Tacotito_s.Factory
{
    internal interface IFactoryMethod
    {       
            IIngrediente GetCreation(TipoCreacion producto);
        
    }
}
