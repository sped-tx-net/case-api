using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFSubject
    {
        public CFSubject()
        {
            CFDocument = new HashSet<CFDocument>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string HierarchyCode { get; set; }
        public string Description { get; set; }
        public DateTime LastChangeDateTime { get; set; }

        public virtual ICollection<CFDocument> CFDocument { get; set; }
    }
}
