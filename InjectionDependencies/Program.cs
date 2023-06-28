using InjectionDependencies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionDependencies
{
    public class Program
    {
        static void Main(string[] args)
        {
            var CustomerService = new CustomerService();
            var communicatonService = new CommunicationService();

            var customers = CustomerService.GetCustomers();
            var message = " Message to broadcast to all customers";
        
            foreach (var customer in customers)
            {
                communicatonService.SendMessage(customer, message);
            }
        }
    }
}
