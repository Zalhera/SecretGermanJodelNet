using SecretGermanJodelNet.Models;
using SecretGermanJodelNet.Models.Account;

namespace SecretGermanJodelNet.Client
{
    public interface IJodelClient : IDisposable
    {
        /// <summary>
        /// Set a custom session cookie
        /// </summary>
        /// <param name="sessionCookie">Session cookie</param>
        void SetSessionCookie(string sessionCookie);
        /// <summary>
        /// Login and authenticate client
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>True if Login succeeded, false otherwise</returns>
        Task<bool> LoginAsync(string username, string password);
        /// <summary>
        /// Get information of currently logged in user
        /// </summary>
        /// <param name="full">Request full information</param>
        /// <returns></returns>
        Task<JodelResponseBase<AccountInfoResponse>?> GetAccountInfo(bool full = true);
    }
}
