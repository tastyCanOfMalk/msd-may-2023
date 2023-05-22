﻿using Microsoft.AspNetCore.Http;

namespace JobListingsApi.Adapters;


// "Typed Http Client"
public class JobsApiHttpAdapter
{
    private readonly HttpClient _httpClient;

    public JobsApiHttpAdapter(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> JobExistsAsync(string jobId)
    {

        var uriBuilder = new UriBuilder(_httpClient.BaseAddress!);
        uriBuilder.Path = $"/jobs/{jobId}";
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Head,

            RequestUri = uriBuilder.Uri
          
        };
        var response = await _httpClient.SendAsync(request);

        if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return false;
        } else
        {
            return true;
        }
        // this looks dumb, but I'll explain more in a bit.
        
    }
}
