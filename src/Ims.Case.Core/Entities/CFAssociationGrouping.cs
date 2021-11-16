using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFAssociationGrouping
    {
        public CFAssociationGrouping()
        {
            CFAssociation = new HashSet<CFAssociation>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastChangeDateTime { get; set; }

        public virtual ICollection<CFAssociation> CFAssociation { get; set; }
    }
}
