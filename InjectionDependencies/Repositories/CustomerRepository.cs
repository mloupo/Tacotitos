using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionDependencies.Repositories
{
    public class CustomerRepository
    {
        private MySQLConnection _conection;
        public CustomerRepository()
        {
            _conection= new MySQLConnection();
        }
        public List<Customer> GetCustomers() //Renombrar a GetAll()
        {
            if (_conection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Get Customers from MySQL");

            return new List<Customer>
            {
                new Customer()
                {
                    Id = 1,
                    Name="John Wick",
                    Email ="JohnWick@kaizen.tec",
                    Address= "Evergreen Av. 742 ",
                    Phone="555-1534-2531"
                },
            new Customer()
            {
                Id = 2,
                Name = "Jeshua",
                Email = "JeshuaIam@kaizen.tec",
                Address = "Everywhere",
                Phone = "Pray"
            }
            };

        }
    }
}
