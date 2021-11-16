using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
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
