using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ims.Case.Models
{
    /// <summary>
    /// This is the container for the status code and associated information returned within the HTTP messages received from the Service Provider.
    /// For the CASE service this object will only be returned to provide information about a failed request i.e. it will NOT be in the payload
    /// for a successful request. See Appendix B for further information on the interpretation of the information contained within this class
    /// </summary>
    public class imsx_StatusInfo
    {
        /// <summary>
        /// success, processing, failure, unsupported
        /// </summary>
        public string imsx_CodeMajor { get; set; }

        /// <summary>
        /// status, warning, error
        /// </summary>
        public string imsx_Severity { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        public string imsx_Description { get; set; }

        public imsx_CodeMinor imsx_CodeMinor { get; set; }
    }

    /// <summary>
    /// This is the container for the set of code minor status codes reported in the responses from the Service Provider.
    /// </summary>
    public class imsx_CodeMinor
    {
        public List<imsx_CodeMinorField> imsx_CodeMinorField { get; set; }
    }

    /// <summary>
    /// This is the container for a single code minor status code.
    /// </summary>
    public class imsx_CodeMinorField
    {
        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        public string imsx_CodeMinorFieldName { get; set; }

        /// <summary>
        /// fullsuccess, invalid_sort_field, invalid_selection_field, forbidden, unauthorizedrequest, internal_server_error, unknownobject, server_busy, invaliduuid
        /// </summary>
        public string imsx_CodeMinorFieldValue { get; set; }
    }
}
