using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
using ApiShopp.Domain.Repository;
using ApiShopp.Domain.Services;
namespace ApiShopp.Services
{
    public class AuthService : IAuthService
    {
        public Task<LoginResponse> Login(LoginRequest request)
        {
            return Task.FromResult(AuthRepository.Login(request));
        }
    }
}
