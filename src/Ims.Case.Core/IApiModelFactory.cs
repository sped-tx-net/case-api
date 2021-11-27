namespace Ims.Case
{
    public interface IApiModelFactory
    {
        Ims.Case.Models.CFAssociation CreateCFAssociation(Ims.Case.Entities.CFAssociation entity);
        Ims.Case.Models.CFAssociationGrouping CreateCFAssociationGrouping(Ims.Case.Entities.CFAssociationGrouping entity);
        Ims.Case.Models.CFConcept CreateCFConcept(Ims.Case.Entities.CFConcept entity);
        Ims.Case.Models.CFDocument CreateCFDocument(Ims.Case.Entities.CFDocument entity);
        Ims.Case.Models.CFItem CreateCFItem(Ims.Case.Entities.CFItem entity);
        Ims.Case.Models.CFItemType CreateCFItemType(Ims.Case.Entities.CFItemType entity);
        Ims.Case.Models.CFLicense CreateCFLicense(Ims.Case.Entities.CFLicense entity);
        Ims.Case.Models.CFRubric CreateCFRubric(Ims.Case.Entities.CFRubric entity);
        Ims.Case.Models.CFRubricCriterion CreateCFRubricCriterion(Ims.Case.Entities.CFRubricCriterion entity);
        Ims.Case.Models.CFRubricCriterionLevel CreateCFRubricCriterionLevel(Ims.Case.Entities.CFRubricCriterionLevel entity);
        Ims.Case.Models.CFSubject CreateCFSubject(Ims.Case.Entities.CFSubject entity);
    }
}
