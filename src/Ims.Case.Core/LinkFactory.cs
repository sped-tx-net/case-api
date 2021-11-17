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


    public class LinkFactory
    {
        public LinkFactory(UriGenerator generator)
        {
            Generator = generator;
        }

        public UriGenerator Generator { get; }

        public LinkURI CreateDocumentLink(Entities.CFDocument element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreatePackageLink(Entities.CFDocument element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element).Replace("CFDocument", "CFPackage")
        };

        public LinkURI CreateSubjectLink(Entities.CFSubject element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateLicenseLink(Entities.CFLicense element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };

        public LinkURI CreateItemTypeLink(Entities.CFItemType element) => new()
        {
            Title = element.Title,
            Identifier = element.UUID(),
            Uri = Generator.Generate(element)
        };
    }
}
