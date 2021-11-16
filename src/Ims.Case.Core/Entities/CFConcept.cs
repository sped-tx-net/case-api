using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFConcept
    {
        public CFConcept()
        {
            CFItem = new HashSet<CFItem>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string HierarchyCode { get; set; }
        public string Description { get; set; }
        public DateTime LastChangeDateTime { get; set; }

        public virtual ICollection<CFItem> CFItem { get; set; }
    }
}
