// <auto-generated />

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
    public partial class CFDocumentsController : ControllerBase
    {
        private readonly ICaseApiSupervisor _supervisor;

        public CFDocumentsController(ICaseApiSupervisor supervisor)
        {
            _supervisor = supervisor;
        }


        [HttpGet("")]
        [SwaggerResponse(
            statusCode: StatusCodes.Status200OK,
            description: "This is the response when the request has been completed successfully. It is the set of CFDocuments from the service provider.",
            type: typeof(CFDocumentSet))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status400BadRequest,
            description: "An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status401Unauthorized,
            description: "The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status403Forbidden,
            description: "This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status404NotFound,
            description: "Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status429TooManyRequests,
            description: "The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status500InternalServerError,
            description: "This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: default,
            description: "This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerOperation(
            OperationId = "getAllCFDocuments",
            Tags = new string[]{"DocumentsManager"},
            Summary = "The REST read request message for the getAllCFDocuments() API call.",
            Description = "This is a request to the Service Provider to provide all of the Competency Framework Documents. ")]
        public async Task<IActionResult> GetAllCFDocumentsAsync(
            [SwaggerParameter(
                description: "This is used as part of the data pagination mechanism to control the download rate of data. The 'limit' defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s).", 
                Required = false)][FromQuery]int limit, 
            [SwaggerParameter(
                description: "This is used as part of the data pagination mechanism to control the download rate of data. The 'offset' is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s).", 
                Required = false)][FromQuery]int offset, 
            [SwaggerParameter(
                description: "This is used as part of the sorting mechanism to be use by the service provider. The 'sort' identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s).", 
                Required = false)][FromQuery]string sort, 
            [SwaggerParameter(
                description: "This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s).", 
                Required = false)][FromQuery]string orderBy, 
            [SwaggerParameter(
                description: "This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s).", 
                Required = false)][FromQuery]string filter, 
            [SwaggerParameter(
                description: "This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s).", 
                Required = false)][FromQuery]List<string> fields, 
            CancellationToken ct = default)
        {
            var retVal = new CFDocumentSet();
            foreach (var document in await _supervisor.GetAllCFDocumentAsync(ct))
                retVal.CFDocuments.Add(document);
            return StatusCode(StatusCodes.Status200OK, retVal);
        }

        [HttpGet("{sourcedId}")]
        [SwaggerResponse(
            statusCode: StatusCodes.Status200OK,
            description: "This is the response when the request has been completed successfully. It is the CFDocument from the service provider.",
            type: typeof(CFDocument))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status400BadRequest,
            description: "An invalid selection field was supplied and data filtering on the selection criteria was not possible i.e. 'invalid_selection_field'. This is accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status401Unauthorized,
            description: "The request was not correctly authorised i.e. 'unauthorisedrequest'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status403Forbidden,
            description: "This is used to indicate that the server can be reached and process the request but refuses to take any further action i.e. 'forbidden'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status404NotFound,
            description: "Either the supplied identifier is unknown in the Service Provider and so the object could not be changed or an invalid UUID has been supplied. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'. The statement 'Unknown Object' of 'Invalid UUID' should also be presented.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status429TooManyRequests,
            description: "The server is receiving too many requests i.e. 'server_busy'. Retry at a later time. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: StatusCodes.Status500InternalServerError,
            description: "This code should be used only if there is catastrophic error and there is not a more appropriate code i.e. 'internal_server_error'. This would be accompanied by the 'codeMajor/severity' values of 'failure/error'.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerResponse(
            statusCode: default,
            description: "This is the response data payload to be supplied when the HTTP code is NOT explicitly defined. This would be accompanied by the 'codeMajor/severity' values of 'failure/error' and the appropriate 'codeMinor' value. The associated HTTP code will also be supplied.",
            type: typeof(imsx_StatusInfo))]
        [SwaggerOperation(
            OperationId = "getCFDocument",
            Tags = new string[]{"DocumentsManager"},
            Summary = "The REST read request message for the getCFDocument() API call.",
            Description = "This is a request to the service provider to provide the information for the specific Competency Framework Document. If the identified record cannot be found then the 'unknownobject' status code must be reported.")]
        public async Task<IActionResult> GetCFDocumentAsync(
            [SwaggerParameter(
                description: "The UUID that identifies the Competency Framework Document that is to be read from the service provider.", 
                Required = true)][FromRoute][Required]string sourcedId, 
            CancellationToken ct = default)
        {
            var retVal = await _supervisor.GetCFDocumentByIdAsync(sourcedId, ct);
            if (retVal == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, ErrorFactory.InvalidUUID);
            }
            return StatusCode(StatusCodes.Status200OK, retVal);
        }
    }
}
