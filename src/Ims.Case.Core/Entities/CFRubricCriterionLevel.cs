using System;
using System.Collections.Generic;

#nullable disable

namespace Ims.Case.Entities
{
    public partial class CFRubricCriterionLevel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Quality { get; set; }
        public double? Score { get; set; }
        public string Feedback { get; set; }
        public int? Position { get; set; }
        public DateTime LastChangeDateTime { get; set; }
        public Guid? RubricCriterionId { get; set; }

        public virtual CFRubricCriterion RubricCriterion { get; set; }
    }
}
