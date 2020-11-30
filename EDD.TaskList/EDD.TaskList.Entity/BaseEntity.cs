using System;
namespace EDD.TaskList.Entity
{
    public abstract class BaseEntity: IEntity
    {
        public Int64? Id {get; private set; }

        public DateTime? CreatedAt { get; private set; }

        public DateTime? UpdatedAt { get; private set; }

        public Boolean? WasDeleted { get; private set; }
    }
}