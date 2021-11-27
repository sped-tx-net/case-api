using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// The container for the set of CFItemTypes supplied in the response payload.The relationship between the
    /// CFItemTypes is determined by the 'hierarchyCode'. The first CFItemType is that which has been specified
    /// in the call.The other CFItemTypes are the set of children as determined by their place in the
    /// 'hierarchyCode' of the CFItemType.
    /// </summary>
    public class CFItemTypeSet
    {
        public CFItemTypeSet()
        {
            CFItemTypes = new List<CFItemType>();
        }

        [JsonProperty("CFItemTypes")]
        public List<CFItemType> CFItemTypes { get; set; }
    }
}
