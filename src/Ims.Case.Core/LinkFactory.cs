using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ims.Case.Entities;
using Ims.Case.Models;
using Ims.Case.Utilities;
using Microsoft.AspNetCore.Http;

namespace Ims.Case
{

    public class LinkFactory : ILinkFactory
    {
        public LinkFactory(IUriGenerator generator)
        {
            Generator = generator;
        }

        public IUriGenerator Generator { get; }


        public LinkURI CreateCFPackageLink(Entities.CFDocument element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element).Replace("CFDocument", "CFPackage")
        };

        public LinkURI CreateCFAssociationLink(Entities.CFAssociation element) => new()
        {
            Title = element.DestinationNodeTitle,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFAssociationGroupingLink(Entities.CFAssociationGrouping element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFConceptLink(Entities.CFConcept element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFDocumentLink(Entities.CFDocument element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFItemLink(Entities.CFItem element) => new()
        {
            Title = element.FullStatement,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFItemTypeLink(Entities.CFItemType element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFLicenseLink(Entities.CFLicense element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFRubricLink(Entities.CFRubric element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFRubricCriterionLink(Entities.CFRubricCriterion element) => new()
        {
            Title = element.Description,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFRubricCriterionLevelLink(Entities.CFRubricCriterionLevel element) => new()
        {
            Title = element.Description,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateCFSubjectLink(Entities.CFSubject element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };
    }
}
