using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFRubric
    {
        public CFRubric()
        {
            CFRubricCriteria = new List<CFRubricCriterion>();
        }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("licenseText")]
        public string LicenseText { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonProperty("CFRubricCriteria")]
        public List<CFRubricCriterion> CFRubricCriteria { get; set; }
    }

}
