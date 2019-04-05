using System;

namespace ICS.Project.DAL.Entities.Base
{
    public abstract class EntityBase : IEntity
    {
        public Guid ID { get; set; }
    }
}
