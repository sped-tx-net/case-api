using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFRubricCriterion
    {
        public CFRubricCriterion()
        {
            CFRubricCriterionLevel = new HashSet<CFRubricCriterionLevel>();
        }

        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public Guid? CFItemId { get; set; }
        public double? Weight { get; set; }
        public int? Position { get; set; }
        public Guid? RubricId { get; set; }
        public DateTime LastChangeDateTime { get; set; }

        public virtual CFItem CFItem { get; set; }
        public virtual CFRubric Rubric { get; set; }
        public virtual ICollection<CFRubricCriterionLevel> CFRubricCriterionLevel { get; set; }
    }
}
