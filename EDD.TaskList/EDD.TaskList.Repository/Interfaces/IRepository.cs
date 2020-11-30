using System;
using EDD.TaskList.Entity;

namespace EDD.TaskList.Repository.Interfaces
{
    public interface IRepository<T> where T: IEntity
    {
        void Save(T entity);
        
        T GetById(Int64 id);

        void Delete(T entity);
    }
}