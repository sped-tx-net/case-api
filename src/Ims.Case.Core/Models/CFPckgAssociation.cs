using System;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFPckgAssociation
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("associationType")]
        public string AssociationType { get; set; }

        [JsonProperty("sequenceNumber")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("originNodeURI")]
        public LinkURI OriginNodeURI { get; set; }

        [JsonProperty("CFAssociationGroupingURI")]
        public LinkURI CFAssociationGroupingURI { get; set; }

        [JsonProperty("destinationNodeURI")]
        public LinkGenURI DestinationNodeURI { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

    }
}
