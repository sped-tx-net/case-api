using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFDocument : CFPckgDocument
    {
        [JsonProperty("CFPackageURI")]
        public LinkURI CFPackageURI { get; set; }
    }

}
