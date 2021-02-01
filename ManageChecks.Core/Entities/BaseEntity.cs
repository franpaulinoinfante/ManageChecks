using System;
using System.Collections.Generic;
using System.Text;

namespace ManageChecks.Core.Entities
{
    public class BaseEntity<TKey>
    {
        public BaseEntity(TKey id)
        {
            Id = id;
        }

        public TKey Id { get; private set; }
    }
}
