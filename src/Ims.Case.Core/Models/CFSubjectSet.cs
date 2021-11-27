using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the set of CFSubjects supplied in the response payload. The relationship between the CFSubjects is determined by the 'hierarchyCode’.
    /// The first CFSubject is that which has been specified in the call. The other CFSubjects are the set of children as determined by their place in the
    /// ‘hierarchyCode’ of the CFSubject.
    /// </summary>
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
