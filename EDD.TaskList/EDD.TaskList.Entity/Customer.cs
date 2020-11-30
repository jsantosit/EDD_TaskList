using System;
namespace EDD.TaskList.Entity
{
    public class Customer: BaseEntity, IEntity
    {
        public String Name { get; private set; }

        public String IdentityCard { get; private set; }
    }
}