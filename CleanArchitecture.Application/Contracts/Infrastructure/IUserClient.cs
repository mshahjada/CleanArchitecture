using CleanArchitecture.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Infrastructure
{
    public interface IUserClient
    {
        Task<ApiResponse> GetUserByIdAsync(int userId);
    }
}
