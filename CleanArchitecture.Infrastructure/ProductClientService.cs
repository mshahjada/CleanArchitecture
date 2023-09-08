using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Model;
using CleanArchitecture.Application.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    internal class ProductClientService : IProductClient
    {
        private readonly HttpClient _client;
        public ProductClientService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse> GetProductByIdAsync(int productId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var response = await _client.GetAsync(productId.ToString());

            apiResponse.StatusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                apiResponse.Data = JsonConvert.DeserializeObject<ProductInfo>(result);
            }

            return apiResponse;
        }
    }
}
