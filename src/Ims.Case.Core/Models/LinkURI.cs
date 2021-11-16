using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class LinkURI
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
