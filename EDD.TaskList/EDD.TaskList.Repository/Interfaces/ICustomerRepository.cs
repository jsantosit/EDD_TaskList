using EDD.TaskList.Entity;

namespace EDD.TaskList.Repository.Interfaces
{
    //public interface ICustomerRepository<T> where T: IEntity
    public interface ICustomerRepository<T>: IRepository<Customer>
    {
    }
}