using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFLicense
    {
        public CFLicense()
        {
            CFDocument = new HashSet<CFDocument>();
            CFItem = new HashSet<CFItem>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LicenseText { get; set; }
        public DateTime LastChangeDateTime { get; set; }

        public virtual ICollection<CFDocument> CFDocument { get; set; }
        public virtual ICollection<CFItem> CFItem { get; set; }
    }
}
