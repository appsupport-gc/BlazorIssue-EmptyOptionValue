using BlazorIssue_EmptyOptionValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorIssue_EmptyOptionValue
{
    public interface IOMDataService
    {
        Task<RESTAdmField[]> FetchRESTAdmFields();
    }

    public class OMRESTDataService : IOMDataService
    {
        public OMRESTDataService(IHttpClientFactory httpClientFactory) => this.httpClientFactory = httpClientFactory;

        private readonly IHttpClientFactory httpClientFactory;

        public async Task<RESTAdmField[]> FetchRESTAdmFields()
        {
            string url = $"http://api.adventistdirectory.org/api/OMAdmField?$filter=Active%20eq%20true&$orderby=YBOrgCode";
            var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync(url);
            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                var data = await JsonSerializer.DeserializeAsync<RESTAdmField[]>(responseStream);
                return data;
            }
        }
    }
}
