using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFPckgDocument
    {
        public CFPckgDocument()
        {
            Subject = new List<string>();
            SubjectURI = new List<LinkURI>();
        }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

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

        [JsonProperty("statusStartDate")]
        public string StatusStartDate { get; set; }

        [JsonProperty("statusEndDate")]
        public string StatusEndDate { get; set; }

        [JsonProperty("licenseURI")]
        public string LicenseURI { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
