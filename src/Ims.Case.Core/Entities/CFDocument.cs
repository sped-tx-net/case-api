using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFDocument
    {
        public CFDocument()
        {
            CFAssociation = new HashSet<CFAssociation>();
            CFItem = new HashSet<CFItem>();
        }

        public Guid Id { get; set; }
        public string Creator { get; set; }
        public string Title { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public string OfficialSourceURL { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public Guid? SubjectId { get; set; }
        public string Language { get; set; }
        public string Version { get; set; }
        public string AdoptionStatus { get; set; }
        public DateTime? StatusStartDate { get; set; }
        public DateTime? StatusEndDate { get; set; }
        public Guid? LicenseId { get; set; }
        public string Notes { get; set; }

        public virtual CFLicense License { get; set; }
        public virtual CFSubject SubjectNavigation { get; set; }
        public virtual ICollection<CFAssociation> CFAssociation { get; set; }
        public virtual ICollection<CFItem> CFItem { get; set; }
    }
}
