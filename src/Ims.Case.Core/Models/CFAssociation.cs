using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFAssociation
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("associationType")]
        public string AssociationType { get; set; }

        [JsonProperty("sequenceNumber")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("OriginNodeURI")]
        public LinkURI OriginNodeURI { get; set; }

        [JsonProperty("DestinationNodeURI")]
        public LinkURI DestinationNodeURI { get; set; }
    }
}
