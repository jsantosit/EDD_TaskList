using System;
namespace EDD.TaskList.Entity
{
    public class Product
    {
        public String Name { get; private set; }

        public String Description { get; private set; }

        public Decimal NominalValue { get; private set; }
    }
}