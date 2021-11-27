using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the information about a license used within the competency framework.
    /// </summary>
    public class CFLicense : CompetencyFrameworkElement
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
        /// </summary>summary>
        [JsonProperty("uri")]
        public override string Uri { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>summary>
        [JsonProperty("licenseText")]
        public string LicenseText { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
