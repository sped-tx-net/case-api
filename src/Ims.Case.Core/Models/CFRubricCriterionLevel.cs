using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFRubricCriterionLevel : CompetencyFrameworkElement
    {
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        [JsonProperty("uri")]
        public override string Uri { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("feedback")]
        public string Feedback { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("rubricCriterionId")]
        public string RubricCriterionId { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }

}
