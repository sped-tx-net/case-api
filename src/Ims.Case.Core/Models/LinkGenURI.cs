using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// A container for the information that is used to achieve the link data reference.
    /// </summary>
    public class LinkGenURI
    {
        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Any URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

    }
}
