using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;

namespace ApiShopp.Domain.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}
