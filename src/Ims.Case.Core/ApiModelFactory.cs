using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ims.Case.Entities;
using Ims.Case.Models;
using Ims.Case.Utilities;
using Microsoft.AspNetCore.Http;

namespace Ims.Case
{
    public class ApiModelFactory
    {
        private readonly LinkFactory _linkFactory;
        private readonly UriGenerator _generator;

        public ApiModelFactory(LinkFactory linkFactory)
        {
            _linkFactory = linkFactory;
            _generator = _linkFactory.Generator;
        }

        public CFDefinition CreateCFDefinitions(CaseApiContext context)
        {
            var model = new CFDefinition();
            foreach (var itemType in context.CFItemType)
                model.CFItemTypes.Add(CreateCFItemType(itemType));
            return model;
        }

        private Ims.Case.Models.CFItemType CreateCFItemType(Ims.Case.Entities.CFItemType entity)
        {
            return new Ims.Case.Models.CFItemType
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
                Title = entity.Title,
                HierarchyCode = entity.HierarchyCode,
                Description = entity.Description
            };
        }

        public CFPackage CreateCFPackage(CaseApiContext context, Ims.Case.Entities.CFDocument entity)
        {
            var model = new CFPackage();
            model.CFDocument = CreateCFDocument(entity);
            model.CFDefinitions = CreateCFDefinitions(context);
            foreach (var item in entity.CFItem)
                model.CFItems.Add(CreateCFItem(item));

            return model;
        }

        public Ims.Case.Models.CFItem CreateCFItem(Ims.Case.Entities.CFItem entity)
        {
            var model = new Ims.Case.Models.CFItem
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
                Notes = entity.Notes,
                Language = entity.Language,
                StatusStartDate = entity.StatusStartDate?.ToString("MM/dd/yyyy"),
                StatusEndDate = entity.StatusEndDate?.ToString("MM/dd/yyyy"),
                FullStatement = entity.FullStatement,
                AlternativeLabel = entity.AlternativeLabel,
                CFItemType = entity.CFItemType,
                HumanCodingScheme = entity.HumanCodingScheme,
                ListEnumeration = entity.ListEnumeration?.ToString(),
            };
            model.CFDocumentURI = _linkFactory.CreateDocumentLink(entity.CFDocument);
            if (entity.CFItemTypeNavigation != null)
                model.CFItemTypeURI = _linkFactory.CreateItemTypeLink(entity.CFItemTypeNavigation);
            if (entity.License != null)
                model.LicenseURI = _linkFactory.CreateLicenseLink(entity.License);
            if (entity.EducationLevel != null)
            {
                if (entity.EducationLevel.Contains(","))
                {
                    foreach (var educationLevel in entity.EducationLevel.Split(","))
                        model.EducationLevel.Add(educationLevel);
                }
                else
                {
                    model.EducationLevel.Add(entity.EducationLevel);
                }
            }

            return model;
        }

        public Ims.Case.Models.CFDocument CreateCFDocument(Ims.Case.Entities.CFDocument entity)
        {
            var model = new Ims.Case.Models.CFDocument
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
                OfficialSourceURL = entity.OfficialSourceURL,
                Language = entity.Language,
                AdoptionStatus = entity.AdoptionStatus,
                Title = entity.Title,
                Description = entity.Description,
                Creator = entity.Creator,
                Publisher = entity.Publisher,
                Notes = entity.Notes,
                StatusStartDate = entity.StatusStartDate?.ToString("MM/dd/yyyy"),
                StatusEndDate = entity.StatusEndDate?.ToString("MM/dd/yyyy"),
            };
            model.Subject.Add(entity.Subject);
            if (entity.SubjectNavigation != null)
                model.SubjectURI.Add(_linkFactory.CreateSubjectLink(entity.SubjectNavigation));
            model.CFPackageURI = _linkFactory.CreatePackageLink(entity);
            if (entity.License != null)
                model.LicenseURI = _linkFactory.CreateLicenseLink(entity.License);
            return model;
        }

        public Ims.Case.Models.CFAssociation CreateCFAssociation(Ims.Case.Entities.CFAssociation entity)
        {
            var model = new Ims.Case.Models.CFAssociation
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
                AssociationType = entity.AssociationType,
                SequenceNumber = entity.SequenceNumber,
                
            };

            return model;
        }

        public Ims.Case.Models.CFAssociationGrouping CreateCFAssociationGrouping(Ims.Case.Entities.CFAssociationGrouping entity)
        {
            var model = new Ims.Case.Models.CFAssociationGrouping
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFAssociationSet CreateCFAssociationSet(CaseApiContext context)
        {
            var model = new Ims.Case.Models.CFAssociationSet();
            foreach (var entity in context.CFAssociation)
            {
                model.CFAssociations.Add(CreateCFAssociation(entity));
            }

            return model;
        }

        public Ims.Case.Models.CFConcept CreateCFConcept(Ims.Case.Entities.CFConcept entity)
        {
            var model = new Ims.Case.Models.CFConcept
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFConceptSet CreateCFConceptSet(CaseApiContext context)
        {
            var model = new Ims.Case.Models.CFConceptSet();
            foreach (var entity in context.CFConcept)
            {
                model.CFConcepts.Add(CreateCFConcept(entity));
            }

            return model;
        }

        public Ims.Case.Models.CFDocumentSet CreateCFDocumentSet(CaseApiContext context)
        {
            var model = new Ims.Case.Models.CFDocumentSet();
            foreach (var entity in context.CFDocument)
            {
                model.CFDocuments.Add(CreateCFDocument(entity));
            }

            return model;
        }

        public Ims.Case.Models.CFItemTypeSet CreateCFItemTypeSet(CaseApiContext context)
        {
            var model = new Ims.Case.Models.CFItemTypeSet();
            foreach (var entity in context.CFItemType)
            {
                model.CFItemTypes.Add(CreateCFItemType(entity));
            }

            return model;
        }

        public Ims.Case.Models.CFLicense CreateCFLicense(Ims.Case.Entities.CFLicense entity)
        {
            var model = new Ims.Case.Models.CFLicense
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFRubric CreateCFRubric(Ims.Case.Entities.CFRubric entity)
        {
            var model = new Ims.Case.Models.CFRubric
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFRubricCriterion CreateCFRubricCriterion(Ims.Case.Entities.CFRubricCriterion entity)
        {
            var model = new Ims.Case.Models.CFRubricCriterion
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFRubricCriterionLevel CreateCFRubricCriterionLevel(Ims.Case.Entities.CFRubricCriterionLevel entity)
        {
            var model = new Ims.Case.Models.CFRubricCriterionLevel
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFSubject CreateCFSubject(Ims.Case.Entities.CFSubject entity)
        {
            var model = new Ims.Case.Models.CFSubject
            {
                Identifier = entity.UUID(),
                Uri = _generator.Generate(entity),
                LastChangeDateTime = entity.LastChangeDateTime(),
            };

            return model;
        }

        public Ims.Case.Models.CFSubjectSet CreateCFSubjectSet(CaseApiContext context)
        {
            var model = new Ims.Case.Models.CFSubjectSet();
            foreach (var entity in context.CFSubject)
            {
                model.CFSubjects.Add(CreateCFSubject(entity));
            }

            return model;
        }
    }
}
