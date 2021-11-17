using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFPckgItem : CompetencyFrameworkElement
    {
        public CFPckgItem()
        {
            ConceptKeywords = new List<string>();
            EducationLevel = new List<string>();
        }

        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        [JsonProperty("fullStatement")]
        public string FullStatement { get; set; }

        [JsonProperty("alternativeLabel")]
        public string AlternativeLabel { get; set; }

        [JsonProperty("CFItemType")]
        public string CFItemType { get; set; }

        [JsonProperty("uri")]
        public override string Uri { get; set; }

        [JsonProperty("humanCodingScheme")]
        public string HumanCodingScheme { get; set; }

        [JsonProperty("listEnumeration")]
        public string ListEnumeration { get; set; }

        [JsonProperty("abbreviatedStatement")]
        public string AbbreviatedStatement { get; set; }

        [JsonProperty("conceptKeywords")]
        public List<string> ConceptKeywords { get; set; }

        [JsonProperty("conceptKeywordsURI")]
        public LinkURI ConceptKeywordsURI { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("educationLevel")]
        public List<string> EducationLevel { get; set; }

        [JsonProperty("CFItemTypeURI")]
        public LinkURI CFItemTypeURI { get; set; }

        [JsonProperty("licenseURI")]
        public LinkURI LicenseURI { get; set; }

        [JsonProperty("statusStartDate")]
        public string StatusStartDate { get; set; }

        [JsonProperty("statusEndDate")]
        public string StatusEndDate { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }

    }
}
