using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFItem
    {
        public CFItem()
        {
            CFRubricCriterion = new HashSet<CFRubricCriterion>();
        }

        public Guid Id { get; set; }
        public string FullStatement { get; set; }
        public string AlternativeLabel { get; set; }
        public string CFItemType { get; set; }
        public string HumanCodingScheme { get; set; }
        public int? ListEnumeration { get; set; }
        public string AbbreviatedStatement { get; set; }
        public string ConceptKeywords { get; set; }
        public Guid? ConceptKeywordsId { get; set; }
        public string Notes { get; set; }
        public string Language { get; set; }
        public string EducationLevel { get; set; }
        public Guid? CFItemTypeId { get; set; }
        public Guid? LicenseId { get; set; }
        public DateTime? StatusStartDate { get; set; }
        public DateTime? StatusEndDate { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid CFDocumentId { get; set; }

        public virtual CFDocument CFDocument { get; set; }
        public virtual CFItemType CFItemTypeNavigation { get; set; }
        public virtual CFConcept ConceptKeywordsNavigation { get; set; }
        public virtual CFLicense License { get; set; }
        public virtual ICollection<CFRubricCriterion> CFRubricCriterion { get; set; }
    }
}
