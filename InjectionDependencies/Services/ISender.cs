using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionDependencies.Services
{
    public interface ISender
    {
        public void Send(Customer customer, string message);
    }
}
