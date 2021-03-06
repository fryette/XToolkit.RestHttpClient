﻿using System.Threading.Tasks;

namespace Softeq.XToolkit.DefaultAuthorization.Abstract
{
    public interface IMembershipService
    {
        string Token { get; }
        string RefreshToken { get; }

        Task SaveTokensAsync(string token, string refreshToken);
        void ResetTokens();
    }
}