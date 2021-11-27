using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ims.Case.Models;

namespace Ims.Case
{
    public static class ErrorFactory
    {
        public static imsx_StatusInfo InvalidSelectionField { get; } = new imsx_StatusInfo
        {
            imsx_CodeMajor = "failure",
            imsx_Severity = "error",
            imsx_Description = "An invalid selection field was supplied and data filtering on the selection criteria was not possible.",
            imsx_CodeMinor = new imsx_CodeMinor
            {
                imsx_CodeMinorField = new List<imsx_CodeMinorField>
                {
                    new imsx_CodeMinorField
                    {
                        imsx_CodeMinorFieldName = "400",
                        imsx_CodeMinorFieldValue = "invalid_selection_field"
                    }
                }
            }
        };

        public static imsx_StatusInfo UnauthorizedRequest { get; } = new imsx_StatusInfo
        {
            imsx_CodeMajor = "failure",
            imsx_Severity = "error",
            imsx_Description = "The request was not correctly authorised.",
            imsx_CodeMinor = new imsx_CodeMinor
            {
                imsx_CodeMinorField = new List<imsx_CodeMinorField>
                {
                    new imsx_CodeMinorField
                    {
                        imsx_CodeMinorFieldName = "401",
                        imsx_CodeMinorFieldValue = "unauthorizedrequest"
                    }
                }
            }
        };

        public static imsx_StatusInfo Forbidden { get; } = new imsx_StatusInfo
        {
            imsx_CodeMajor = "failure",
            imsx_Severity = "error",
            imsx_Description = "This is used to indicate that the server can be reached and process the request but refuses to take any further action.",
            imsx_CodeMinor = new imsx_CodeMinor
            {
                imsx_CodeMinorField = new List<imsx_CodeMinorField>
                {
                    new imsx_CodeMinorField
                    {
                        imsx_CodeMinorFieldName = "403",
                        imsx_CodeMinorFieldValue = "forbidden"
                    }
                }
            }
        };

        public static imsx_StatusInfo InvalidUUID { get; } = new imsx_StatusInfo
        {
            imsx_CodeMajor = "failure",
            imsx_Severity = "error",
            imsx_Description = "An Invalid UUID has been supplied.",
            imsx_CodeMinor = new imsx_CodeMinor
            {
                imsx_CodeMinorField = new List<imsx_CodeMinorField>
                {
                    new imsx_CodeMinorField
                    {
                        imsx_CodeMinorFieldName = "404",
                        imsx_CodeMinorFieldValue = "invaliduuid"
                    }
                }
            }
        };

        public static imsx_StatusInfo ServerBusy { get; } = new imsx_StatusInfo
        {
            imsx_CodeMajor = "failure",
            imsx_Severity = "error",
            imsx_Description = "The server is receiving too many requests",
            imsx_CodeMinor = new imsx_CodeMinor
            {
                imsx_CodeMinorField = new List<imsx_CodeMinorField>
                {
                    new imsx_CodeMinorField
                    {
                        imsx_CodeMinorFieldName = "429",
                        imsx_CodeMinorFieldValue = "server_busy"
                    }
                }
            }
        };

        public static imsx_StatusInfo ServerError { get; } = new imsx_StatusInfo
        {
            imsx_CodeMajor = "failure",
            imsx_Severity = "error",
            imsx_Description = "The server experienced a catastropic error.",
            imsx_CodeMinor = new imsx_CodeMinor
            {
                imsx_CodeMinorField = new List<imsx_CodeMinorField>
                {
                    new imsx_CodeMinorField
                    {
                        imsx_CodeMinorFieldName = "500",
                        imsx_CodeMinorFieldValue = "internal_server_error"
                    }
                }
            }
        };
    }
}
