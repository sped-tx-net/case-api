using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFPckgDocument : CompetencyFrameworkElement
    {
        public CFPckgDocument()
        {
            Subject = new List<string>();
            SubjectURI = new List<LinkURI>();
        }

        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        [JsonProperty("uri")]
        public override string Uri { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }

        [JsonProperty("officialSourceURL")]
        public string OfficialSourceURL { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public List<string> Subject { get; set; }

        [JsonProperty("subjectURI")]
        public List<LinkURI> SubjectURI { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("adoptionStatus")]
        public string AdoptionStatus { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("statusStartDate")]
        public string StatusStartDate { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Date
        /// </summary>
        [JsonProperty("statusEndDate")]
        public string StatusEndDate { get; set; }

        [JsonProperty("licenseURI")]
        public LinkURI LicenseURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
