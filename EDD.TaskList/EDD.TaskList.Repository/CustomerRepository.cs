using System.Security.AccessControl;
using System.Collections.Generic;
using EDD.TaskList.Entity;
using System;
using Dapper;
using EDD.TaskList.Repository.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EDD.TaskList.Repository
{
    public class CustomerRepository<T> : BaseRepository, IRepository<Customer>, ICustomerRepository<IEntity>
    {
        public CustomerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Save(Customer entity)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Name", entity.Name);
            parameters.Add("IdentityCard", entity.IdentityCard);

            this._save("InsertCustomer", parameters);
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}