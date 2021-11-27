using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for the CFItem data within the context of a CFPackage. This is the content that either describes a specific
    /// competency (learning objective) or describes a grouping of competencies within the taxonomy of a Competency Framework Document.
    /// </summary>
    public class CFPckgItem : CompetencyFrameworkElement
    {
        public CFPckgItem()
        {
            ConceptKeywords = new List<string>();
            EducationLevel = new List<string>();
        }

        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a Universally Unique Identifier (UUID)
        /// of 16 hexadecimal characters (lower case) in the format 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("fullStatement")]
        public string FullStatement { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("alternativeLabel")]
        public string AlternativeLabel { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("CFItemType")]
        public string CFItemType { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        [JsonProperty("uri")]
        public override string Uri { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("humanCodingScheme")]
        public string HumanCodingScheme { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("listEnumeration")]
        public string ListEnumeration { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("abbreviatedStatement")]
        public string AbbreviatedStatement { get; set; }

        [JsonProperty("conceptKeywords")]
        public List<string> ConceptKeywords { get; set; }

        [JsonProperty("conceptKeywordsURI")]
        public LinkURI ConceptKeywordsURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Language
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("educationLevel")]
        public List<string> EducationLevel { get; set; }

        [JsonProperty("CFItemTypeURI")]
        public LinkURI CFItemTypeURI { get; set; }

        [JsonProperty("licenseURI")]
        public LinkURI LicenseURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Date
        /// </summary>
        [JsonProperty("statusStartDate")]
        public string StatusStartDate { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Date
        /// </summary>
        [JsonProperty("statusEndDate")]
        public string StatusEndDate { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
