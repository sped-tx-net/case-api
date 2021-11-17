using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFItemType : CompetencyFrameworkElement
    {
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        [JsonProperty("uri")]
        public override string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hierarchyCode")]
        public string HierarchyCode { get; set; }

        [JsonProperty("typeCode")]
        public string TypeCode { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
