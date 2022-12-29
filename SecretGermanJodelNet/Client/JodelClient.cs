using SecretGermanJodelNet.Constants;
using SecretGermanJodelNet.Models;
using SecretGermanJodelNet.Models.Account;
using System.Net;
using System.Text.Json;

namespace SecretGermanJodelNet.Client
{
    public sealed class JodelClient : IJodelClient
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _handler;
        private readonly CookieContainer _cookieContainer;

        public JodelClient()
        {
            _cookieContainer = new CookieContainer();
            _handler = new HttpClientHandler()
            {
                CookieContainer = _cookieContainer,
                UseCookies = true,
            };
            _httpClient = new HttpClient(_handler)
            {
                BaseAddress = new Uri(Routes.ApiBaseUrl),
            };
            _httpClient.DefaultRequestHeaders.Add("Origin", "https://secretgermanjodel.com");
        }

        private async Task<JodelResponseBase<T>?> PostAsync<T>(string url, HttpContent? content)
            where T : class
        {
            using (var response = await _httpClient.PostAsync(url, content))
            {
                if (!response.IsSuccessStatusCode)
                {
                    return default;
                }

                return JsonSerializer.Deserialize<JodelResponseBase<T>>(await response.Content.ReadAsStringAsync());
            }
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
            _handler?.Dispose();
        }

        /// <inheritdoc/>
        public async Task<bool> LoginAsync(string username, string password)
        {
            var loginParameters = new Dictionary<string, string>()
            {
                { Parameters.Account.UsernameFormName, username },
                { Parameters.Account.PasswordFormName, password },
            };

            var loginFormData = new FormUrlEncodedContent(loginParameters);
            var loginResponse = await PostAsync<LoginResponse>(Routes.LoginRoute, loginFormData);

            if (string.IsNullOrEmpty(loginResponse?.Result?.Token))
            {
                return false;
            }

            SetSessionCookie(loginResponse.Result.Token);
            return true;
        }

        /// <inheritdoc/>
        public void SetSessionCookie(string sessionCookie)
        {
            _cookieContainer.Add(new Uri(Routes.BaseUrl), new Cookie(Parameters.Account.TokenCookieName, sessionCookie));
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<AccountInfoResponse>?> GetAccountInfo(bool full = true)
        {
            var accountInfoFormData = full ? new FormUrlEncodedContent(new Dictionary<string, string>() { { Parameters.FullFormName, "1" } }) : null;
            return await PostAsync<AccountInfoResponse>(Routes.InfoRoute, accountInfoFormData);
        }
    }
}
