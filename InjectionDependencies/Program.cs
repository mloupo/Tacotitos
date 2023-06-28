using InjectionDependencies.Repositories;
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
            ISender sender = new SMSService();
            IDbConnection connection = new MySQLConnection();
            IRepository repository = new CustomerRepository(connection);

            var CustomerService = new CustomerService(repository);
            var communicatonService = new CommunicationService(sender);

            var customers = CustomerService.GetCustomers();
            var message = " Message to broadcast to all customers";
        
            foreach (var customer in customers)
            {
                communicatonService.SendMessage(customer, message);
            }
        }
    }
}
