﻿using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Queries.GetAll;
using HelpDesk.Architecture.Client.Infrastructure.Extensions;
using HelpDesk.Architecture.Shared.Wrapper;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Misc.DocumentType
{
    public class DocumentTypeManager : IDocumentTypeManager
    {
        private readonly HttpClient _httpClient;

        public DocumentTypeManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.DocumentTypesEndpoints.Export
                : Routes.DocumentTypesEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.DocumentTypesEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DocumentTypesEndpoints.GetAll);
            return await response.ToResult<List<GetAllDocumentTypesResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.DocumentTypesEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}