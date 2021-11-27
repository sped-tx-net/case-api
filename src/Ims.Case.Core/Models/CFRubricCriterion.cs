using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the definition of a rubric criterion which is addressed by the competency framework.
    /// </summary>
    public class CFRubricCriterion : CompetencyFrameworkElement
    {
        public CFRubricCriterion()
        {
            CFRubricCriterionLevels = new List<CFRubricCriterionLevel>();
        }

        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a Universally Unique Identifier (UUID)
        /// of 16 hexadecimal characters (lower case) in the format 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        [JsonProperty("uri")]
        public override string Uri { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("CFItemURI")]
        public LinkURI CFItemURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Integer
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a Universally Unique Identifier (UUID)
        /// of 16 hexadecimal characters (lower case) in the format 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("rubricId")]
        public string RubricId { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }

        [JsonProperty("CFRubricCriterionLevels")]
        public List<CFRubricCriterionLevel> CFRubricCriterionLevels { get; set; }
    }
}
