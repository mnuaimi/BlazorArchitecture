﻿using HelpDesk.Architecture.Application.Features.Documents.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Documents.Commands.Delete;
using HelpDesk.Architecture.Application.Features.Documents.Queries.GetAll;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.Documents.Queries.GetById;
using HelpDesk.Architecture.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;

namespace HelpDesk.Architecture.Server.Controllers.Utilities.Misc
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : BaseApiController<DocumentsController>
    {
        /// <summary>
        /// Get All Documents
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchString"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Documents.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize, string searchString)
        {
            var docs = await _mediator.Send(new GetAllDocumentsQuery(pageNumber, pageSize, searchString));
            return Ok(docs);
        }

        /// <summary>
        /// Get Document By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [Authorize(Policy = Permissions.Documents.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var document = await _mediator.Send(new GetDocumentByIdQuery { Id = id });
            return Ok(document);
        }

        /// <summary>
        /// Add/Edit Document
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Documents.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditDocumentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Document
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK</returns>
        [Authorize(Policy = Permissions.Documents.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteDocumentCommand { Id = id }));
        }
    }
}