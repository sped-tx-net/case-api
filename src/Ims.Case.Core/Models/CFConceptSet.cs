using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
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
