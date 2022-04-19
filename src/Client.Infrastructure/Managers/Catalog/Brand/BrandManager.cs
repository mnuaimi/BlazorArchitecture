﻿using HelpDesk.Architecture.Application.Features.Brands.Queries.GetAll;
using HelpDesk.Architecture.Client.Infrastructure.Extensions;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.Brands.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Brands.Commands.Import;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Catalog.Brand
{
    public class BrandManager : IBrandManager
    {
        private readonly HttpClient _httpClient;

        public BrandManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.BrandsEndpoints.Export
                : Routes.BrandsEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.BrandsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.BrandsEndpoints.GetAll);
            return await response.ToResult<List<GetAllBrandsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditBrandCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.BrandsEndpoints.Save, request);
            return await response.ToResult<int>();
        }

        public async Task<IResult<int>> ImportAsync(ImportBrandsCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.BrandsEndpoints.Import, request);
            return await response.ToResult<int>();
        }
    }
}