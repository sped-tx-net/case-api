using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFSubjectSet
    {
        public CFSubjectSet()
        {
            CFSubjects = new List<CFSubject>();
        }

        [JsonProperty("CFSubjects")]
        public List<CFSubject> CFSubjects { get; set; }
    }

}
