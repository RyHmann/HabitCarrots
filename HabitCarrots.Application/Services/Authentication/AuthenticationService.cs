using HabitCarrots.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCarrots.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerators _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerators jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }
        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(
                Guid.NewGuid(),
                firstName,
                lastName,
                email,
                token
                );
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult
                (
                    Guid.NewGuid(),
                    "firstName",
                    "lastName",
                    email,
                    "token"
                );
        }
    }
}
