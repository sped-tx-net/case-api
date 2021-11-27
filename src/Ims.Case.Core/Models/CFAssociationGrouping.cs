using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

#nullable disable

namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for information about a set of associations that have been labelled as
    /// a group (the nature of the group being defined by this container).
    /// </summary>
    public class CFAssociationGrouping : CompetencyFrameworkElement
    {
        /// <summary>
        /// The data-type for establishing a Globally Unique Identifier (GUID). The form of the GUID is a
        /// Universally Unique Identifier (UUID) of 16 hexadecimal characters (lower case) in the format
        /// 8-4-4-4-12. All permitted versions (1-5) and variants (1-2) are supported.
        /// </summary>
        [JsonProperty("identifier")]
        public override string Identifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        [JsonProperty("uri")]
        public override string Uri { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        [JsonProperty("lastChangeDateTime")]
        public override string LastChangeDateTime { get; set; }
    }
}
