



namespace WebApi.Authentication
{
    using ApiModels;
    using Microsoft.IdentityModel.Tokens;
    using System;
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);
        TokenValidationParameters GetValidationParameters();
    }
}
