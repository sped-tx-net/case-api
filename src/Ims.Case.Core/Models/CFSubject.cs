using System;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFSubject : CompetencyFrameworkElement
    {
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        [JsonProperty("uri")]
        public override string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hierarchyCode")]
        public string HierarchyCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }

    }

}
