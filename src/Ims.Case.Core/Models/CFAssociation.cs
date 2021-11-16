using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFAssociation : CFPckgAssociation
    {

        [JsonProperty("CFDocumentURI")]
        public LinkURI CFDocumentURI { get; set; }
    }
}
