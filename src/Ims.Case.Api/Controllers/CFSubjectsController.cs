using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Ims.Case.Models;
using Ims.Case.Supervisor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Ims.Case.Controllers
{
    [ApiController]
    [Route("/ims/case/v1p0/[controller]")]
    public partial class CFSubjectsController : ControllerBase
    {
        private readonly ICaseApiSupervisor _supervisor;

        public CFSubjectsController(ICaseApiSupervisor supervisor)
        {
            _supervisor = supervisor;
        }

        [HttpGet("{sourcedId}")]
        [SwaggerResponse(
            statusCode: StatusCodes.Status200OK,
            description: "This is the response when the request has been completed successfully. It is the CFSubject and child CFSubjects from the service provider.",
            contentTypes: "application/json",
            type: typeof(CFSubjectSet))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status400BadRequest,
            description: "An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status401Unauthorized,
            description: "The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status403Forbidden,
            description: "This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status404NotFound,
            description: "Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status429TooManyRequests,
            description: "The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status500InternalServerError,
            description: "This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: default,
            description: "This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied.",
            contentTypes: "application/json",
            type: typeof(imsx_StatusInfo))]
        [SwaggerOperation(
            OperationId = "getCFSubject",
            Tags = new string[]{"DefinitionsManager"},
            Summary = "The REST read request message for the getCFSubject() API call.",
            Description = "This is a request to the Service Provider to provide the specified Competency Framework Subject and the set of children CFSubjects as identified by the hierarchy codes.  If the identified record cannot be found then the 'unknownobject' status code must be reported.")]
        public async Task<IActionResult> GetCFSubjectAsync(
            [SwaggerParameter(
                description: "The UUID that identifies the Competency Framework Subject that is to be read from the service provider.", 
                Required = true)][FromRoute][Required]string sourcedId, 
            CancellationToken ct = default)
        {
            var retVal = new CFSubjectSet();
            var subject = await _supervisor.GetCFSubjectByIdAsync(sourcedId, ct);
            if (subject != null)
                retVal.CFSubjects.Add(subject);
            return StatusCode(StatusCodes.Status200OK, retVal);
        }
    }
}
