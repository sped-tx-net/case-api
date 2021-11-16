using System;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFSubject
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hierarchyCode")]
        public string HierarchyCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

    }

}
