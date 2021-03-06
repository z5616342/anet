﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anet.Data.Entity
{
    public abstract class EntityBase<TKey> : IEntity<TKey>
        where TKey: IEquatable<TKey>
    {
        public virtual TKey Id { get; set; }
        public abstract void SetId();
    }

    public abstract class EntityBase : EntityBase<long>, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long Id { get; set; }

        public override void SetId()
        {
            Id = IdGen.NewId();
        }
    }
}
