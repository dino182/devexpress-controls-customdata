using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using System.Net.Http.Json;
using DevExpress.Blazor;

namespace BlazorApp.Client;

public class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<LoadResult> GetItems(DataSourceLoadOptionsBase loadOptions, CancellationToken cancellationToken = default) => await _httpClient.GetFromJsonAsync<LoadResult>(loadOptions.ConvertToGetRequestUri("api/item"), cancellationToken);
}
