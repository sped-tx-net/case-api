using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the definition of a criterion level which is addressed by the competency framework.
    /// </summary>
    public class CFRubricCriterionLevel : CompetencyFrameworkElement
    {
        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a
        /// Universally Unique Identifier (UUID) of 16 hexadecimal characters (lower case) in the format
        /// 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        [JsonProperty("uri")]
        public override string Uri { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        [JsonProperty("score")]
        public double Score { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Integer
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a
        /// Universally Unique Identifier (UUID) of 16 hexadecimal characters (lower case) in the format
        /// 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("rubricCriterionId")]
        public string RubricCriterionId { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
