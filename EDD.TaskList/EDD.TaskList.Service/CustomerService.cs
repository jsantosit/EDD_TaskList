using System;
using EDD.TaskList.Entity;
using EDD.TaskList.Repository.Interfaces;
using EDD.TaskList.Service.Interfaces;

namespace EDD.TaskList.Service
{
    public class CustomerService: ICustomerService
    {
        ICustomerRepository<Customer> _customerRepository;
        public CustomerService(ICustomerRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
