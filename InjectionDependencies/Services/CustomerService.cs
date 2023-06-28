﻿using InjectionDependencies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionDependencies.Services
{
    public class CustomerService
    {
        private IRepository _repository;
        
        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
