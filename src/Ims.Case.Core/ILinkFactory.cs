using Ims.Case.Models;

namespace Ims.Case
{
    public interface ILinkFactory
    {
        IUriGenerator Generator { get; }
        Ims.Case.Models.LinkURI CreateCFAssociationLink(Ims.Case.Entities.CFAssociation element);
        Ims.Case.Models.LinkURI CreateCFAssociationGroupingLink(Ims.Case.Entities.CFAssociationGrouping element);
        Ims.Case.Models.LinkURI CreateCFConceptLink(Ims.Case.Entities.CFConcept element);
        Ims.Case.Models.LinkURI CreateCFDocumentLink(Ims.Case.Entities.CFDocument element);
        Ims.Case.Models.LinkURI CreateCFItemLink(Ims.Case.Entities.CFItem element);
        Ims.Case.Models.LinkURI CreateCFItemTypeLink(Ims.Case.Entities.CFItemType element);
        Ims.Case.Models.LinkURI CreateCFLicenseLink(Ims.Case.Entities.CFLicense element);
        Ims.Case.Models.LinkURI CreateCFRubricLink(Ims.Case.Entities.CFRubric element);
        Ims.Case.Models.LinkURI CreateCFRubricCriterionLink(Ims.Case.Entities.CFRubricCriterion element);
        Ims.Case.Models.LinkURI CreateCFRubricCriterionLevelLink(Ims.Case.Entities.CFRubricCriterionLevel element);
        Ims.Case.Models.LinkURI CreateCFSubjectLink(Ims.Case.Entities.CFSubject element);
        Ims.Case.Models.LinkURI CreateCFPackageLink(Ims.Case.Entities.CFDocument element);

    }
}
