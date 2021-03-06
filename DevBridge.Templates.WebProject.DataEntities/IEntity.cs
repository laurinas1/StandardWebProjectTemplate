﻿using System;

namespace DevBridge.Templates.WebProject.DataEntities
{
    public interface IEntity
    {
        object Id { get; set; }
    }

    public interface IPersistentEntity : IEntity
    {
        DateTime ModifiedOn { get; set; }

        string ModifiedBy { get; set; }

        DateTime CreatedOn { get; set; }

        string CreatedBy { get; set; }

        DateTime? DeletedOn { get; set; }

        string DeletedBy { get; set; }
    }

    public interface IEntity<TId> : IEntity where TId : struct
    {
        new TId Id { get; set; }
    }

    public interface IPersistentEntity<TId> : IPersistentEntity, IEntity<TId> where TId : struct
    {
    }
}
