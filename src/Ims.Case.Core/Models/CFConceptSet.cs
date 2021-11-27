using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the set of CFConcepts supplied in the response payload. The relationship between the CFConcepts is determined by the 'hierarchyCode'.
    /// The first CFConcept is that which has been specified in the call. The other CFConcepts are the set of children as determined by their place in the
    /// 'hierarchyCode' of the CFConcept.
    /// </summary>
    public class CFConceptSet
    {
        public CFConceptSet()
        {
            CFConcepts = new List<CFConcept>();
        }

        [JsonProperty("CFConcepts")]
        public List<CFConcept> CFConcepts { get; set; }
    }
}
