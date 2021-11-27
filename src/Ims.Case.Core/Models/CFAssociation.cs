using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for the data about the relationship between two CFDocuments or between two CFItems outside of the context of a CFPackage or CFItem.
    /// </summary>
    public class CFAssociation : CFPckgAssociation
    {
        [JsonProperty("CFDocumentURI")]
        public LinkURI CFDocumentURI { get; set; }
    }
}
