using System.Collections.Generic;
using Ims.Case.Entities;
using Newtonsoft.Json;


namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for a collection of CFDocuments.There must be at least one CFDocument.
    /// </summary>
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
