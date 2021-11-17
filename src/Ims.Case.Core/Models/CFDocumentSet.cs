using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{

    public class CFDocumentSet
    {
        public CFDocumentSet()
        {
            CFDocuments = new List<CFDocument>();
        }

        [JsonProperty("CFDocuments")]
        public List<CFDocument> CFDocuments { get; set; }
    }

}
