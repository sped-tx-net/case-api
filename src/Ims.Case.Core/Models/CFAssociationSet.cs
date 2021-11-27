using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for a collection of CFAssociations. There must be at least one CFAssociation.
    /// Note that the association can be between CFDocuments or between CFItems.
    /// </summary>
    public class CFAssociationSet
    {
        public CFAssociationSet()
        {
            CFAssociations = new List<CFAssociation>();
        }

        [JsonProperty("CFItem")]
        public CFItem CFItem { get; set; }

        [JsonProperty("CFAssociations")]
        public List<CFAssociation> CFAssociations { get; set; }
    }
}
