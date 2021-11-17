using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ims.Case.Entities
{
    public interface ICFEntityType
    {
        Guid Id { get; }

        DateTime LastChangeDateTime { get; }

    }

    public partial class CFAssociation : ICFEntityType
    {
    }

    public partial class CFAssociationGrouping : ICFEntityType
    {
    }

    public partial class CFConcept : ICFEntityType
    {
    }

    public partial class CFDocument : ICFEntityType
    {
    }

    public partial class CFItem : ICFEntityType
    {
    }

    public partial class CFItemType : ICFEntityType
    {
    }

    public partial class CFLicense : ICFEntityType
    {
    }

    public partial class CFRubric : ICFEntityType
    {
    }

    public partial class CFRubricCriterion : ICFEntityType
    {
    }

    public partial class CFRubricCriterionLevel : ICFEntityType
    {
    }

    public partial class CFSubject : ICFEntityType
    {
    }
}
