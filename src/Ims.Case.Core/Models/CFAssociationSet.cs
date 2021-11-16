using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFAssociationSet
    {
        public CFAssociationSet()
        {
            CFAssociations = new List<CFAssociation>();
        }

        [JsonProperty("CFAssociations")]
        public List<CFAssociation> CFAssociations { get; set; }
    }
}
