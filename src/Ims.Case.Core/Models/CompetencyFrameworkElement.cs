using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CompetencyFrameworkElement : ICompetencyFrameworkElement
    {
        [JsonProperty("identifier")]
        public virtual string Identifier { get; set; }

        [JsonProperty("uri")]
        public virtual string Uri { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public virtual string LastChangeDateTime { get; set; }
    }
}
