using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the definition of a concept which is addressed by the competency framework.
    /// </summary>
    public class CFConcept : CompetencyFrameworkElement
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
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("hierarchyCode")]
        public string HierarchyCode { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
