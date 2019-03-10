using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL.Entities
{
    public abstract class EntityBase : IEntity
    {
        public Guid ID { get; set; }
    }
}
