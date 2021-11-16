using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFPackage
    {
        public CFPackage()
        {
            CFItems = new List<CFPckgItem>();
            CFAssociations = new List<CFPckgAssociation>();
            CFRubrics = new List<CFRubric>();
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
