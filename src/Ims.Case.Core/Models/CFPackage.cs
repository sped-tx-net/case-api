using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for all of the data for a Competency Framework Package i.e. the root
    /// CFDocument and ALL of the corresponding components i.e., the CFItems, CFAssociations,
    /// CFDefinitions, and CFRubrics.
    /// </summary>
    public class CFPackage
    {
        public CFPackage()
        {
            CFItems = new List<CFPckgItem>();
            CFAssociations = new List<CFPckgAssociation>();
            CFRubrics = new List<CFRubric>();
            CFDefinitions = new CFDefinition();
        }

        [JsonProperty("CFDocument")]
        public CFPckgDocument CFDocument { get; set; }

        [JsonProperty("CFItems")]
        public List<CFPckgItem> CFItems { get; set; }

        [JsonProperty("CFAssociations")]
        public List<CFPckgAssociation> CFAssociations { get; set; }

        [JsonProperty("CFDefinitions")]
        public CFDefinition CFDefinitions { get; set; }

        [JsonProperty("CFRubrics")]
        public List<CFRubric> CFRubrics { get; set; }
    }
}
