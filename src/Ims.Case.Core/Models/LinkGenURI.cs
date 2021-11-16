using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class LinkGenURI
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
