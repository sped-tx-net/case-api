using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFPckgAssociation : CompetencyFrameworkElement
    {
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        [JsonProperty("associationType")]
        public string AssociationType { get; set; }

        [JsonProperty("sequenceNumber")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("uri")]
        public override string Uri { get; set; }

        [JsonProperty("originNodeURI")]
        public LinkGenURI OriginNodeURI { get; set; }

        [JsonProperty("destinationNodeURI")]
        public LinkGenURI DestinationNodeURI { get; set; }

        [JsonProperty("CFAssociationGroupingURI")]
        public LinkURI CFAssociationGroupingURI { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
