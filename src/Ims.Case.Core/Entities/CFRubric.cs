using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFRubric
    {
        public CFRubric()
        {
            CFRubricCriterion = new HashSet<CFRubricCriterion>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastChangeDateTime { get; set; }

        public virtual ICollection<CFRubricCriterion> CFRubricCriterion { get; set; }
    }
}
