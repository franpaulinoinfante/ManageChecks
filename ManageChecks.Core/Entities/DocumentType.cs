using System;
using System.Collections.Generic;
using System.Text;

namespace ManageChecks.Core.Entities
{
    public class DocumentType : BaseEntity<int>
    {
        public DocumentType(int id, string description) : base(id)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
