using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Model;
using CleanArchitecture.Application.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    internal class UserClientService: IUserClient
    {
        private readonly HttpClient _httpClient;
        public UserClientService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<ApiResponse> GetUserByIdAsync(int userId)
        {
            ApiResponse apiResponse = new ApiResponse();

            var response = await _httpClient.GetAsync(userId.ToString());

            apiResponse.StatusCode = apiResponse.StatusCode;
            if (response.IsSuccessStatusCode) 
            {
                string content = await response.Content.ReadAsStringAsync();
                apiResponse.Data = JsonConvert.DeserializeObject<UserInfo>(content);
            }

            return apiResponse;
        }
    }
}
