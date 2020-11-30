using System;

namespace EDD.TaskList.Entity
{
    public interface IEntity
    {
         Int64? Id { get; }

        DateTime? CreatedAt { get; }

        DateTime? UpdatedAt { get; }

        Boolean? WasDeleted { get; }
    }
}