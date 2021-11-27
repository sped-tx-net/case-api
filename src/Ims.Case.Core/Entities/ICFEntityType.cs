using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ims.Case.Converters;

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


    public partial class CFAssociation : IConvertModel<CFAssociation, Ims.Case.Models.CFAssociation>
    {
        public Ims.Case.Models.CFAssociation Convert() =>
            new Ims.Case.Models.CFAssociation
            {
            };
    }

    public partial class CFAssociationGrouping : IConvertModel<CFAssociationGrouping, Ims.Case.Models.CFAssociationGrouping>
    {
        public Ims.Case.Models.CFAssociationGrouping Convert() =>
            new Ims.Case.Models.CFAssociationGrouping
            {
            };
    }

    public partial class CFConcept : IConvertModel<CFConcept, Ims.Case.Models.CFConcept>
    {
        public Ims.Case.Models.CFConcept Convert() =>
            new Ims.Case.Models.CFConcept
            {
            };
    }

    public partial class CFDocument : IConvertModel<CFDocument, Ims.Case.Models.CFDocument>
    {
        public Ims.Case.Models.CFDocument Convert() =>
            new Ims.Case.Models.CFDocument
            {
            };
    }

    public partial class CFItem : IConvertModel<CFItem, Ims.Case.Models.CFItem>
    {
        public Ims.Case.Models.CFItem Convert() =>
            new Ims.Case.Models.CFItem
            {
            };
    }

    public partial class CFItemType : IConvertModel<CFItemType, Ims.Case.Models.CFItemType>
    {
        public Ims.Case.Models.CFItemType Convert() =>
            new Ims.Case.Models.CFItemType
            {
            };
    }

    public partial class CFLicense : IConvertModel<CFLicense, Ims.Case.Models.CFLicense>
    {
        public Ims.Case.Models.CFLicense Convert() =>
            new Ims.Case.Models.CFLicense
            {
            };
    }

    public partial class CFRubric : IConvertModel<CFRubric, Ims.Case.Models.CFRubric>
    {
        public Ims.Case.Models.CFRubric Convert() =>
            new Ims.Case.Models.CFRubric
            {
            };
    }

    public partial class CFRubricCriterion : IConvertModel<CFRubricCriterion, Ims.Case.Models.CFRubricCriterion>
    {
        public Ims.Case.Models.CFRubricCriterion Convert() =>
            new Ims.Case.Models.CFRubricCriterion
            {
            };
    }

    public partial class CFRubricCriterionLevel : IConvertModel<CFRubricCriterionLevel, Ims.Case.Models.CFRubricCriterionLevel>
    {
        public Ims.Case.Models.CFRubricCriterionLevel Convert() =>
            new Ims.Case.Models.CFRubricCriterionLevel
            {
            };
    }

    public partial class CFSubject : IConvertModel<CFSubject, Ims.Case.Models.CFSubject>
    {
        public Ims.Case.Models.CFSubject Convert() =>
            new Ims.Case.Models.CFSubject
            {
            };
    }

}
