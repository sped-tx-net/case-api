using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFDefinition
    {
        public CFDefinition()
        {
            CFConcepts = new List<CFConcept>();
            CFSubjects = new List<CFSubject>();
            CFLicenses = new List<CFLicense>();
            CFItemTypes = new List<CFItemType>();
            CFAssociationGroupings = new List<CFAssociationGrouping>();
        }

        [JsonProperty("CFConcepts")]
        public List<CFConcept> CFConcepts { get; set; }

        [JsonProperty("CFSubjects")]
        public List<CFSubject> CFSubjects { get; set; }

        [JsonProperty("CFLicenses")]
        public List<CFLicense> CFLicenses { get; set; }

        [JsonProperty("CFItemTypes")]
        public List<CFItemType> CFItemTypes { get; set; }

        [JsonProperty("CFAssociationGroupings")]
        public List<CFAssociationGrouping> CFAssociationGroupings { get; set; }
    }

}
