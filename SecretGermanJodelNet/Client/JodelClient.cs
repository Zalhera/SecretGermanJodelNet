using SecretGermanJodelNet.Constants;
using SecretGermanJodelNet.Exception;
using SecretGermanJodelNet.Models;
using SecretGermanJodelNet.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Client
{
    public class JodelClient : IJodelClient
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
        }

        private async Task<T?> PostAsync<T>(string url, HttpContent content)
            where T : class
        {
            using (var response = await _httpClient.PostAsync(url, content))
            {
                if (!response.IsSuccessStatusCode)
                {
                    return default(T);
                }

                return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
            }
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
            _handler?.Dispose();
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var loginParameters = new Dictionary<string, string>()
            {
                { Parameters.Account.UsernameFormName, username },
                { Parameters.Account.PasswordFormName, password },
            };

            var loginFormData = new FormUrlEncodedContent(loginParameters);

            var loginResponse = await PostAsync<JodelResponseBase<LoginResponse>>(Routes.LoginRoute, loginFormData);

            if(string.IsNullOrEmpty(loginResponse?.Result?.Token))
            {
                throw new JodelException("Login was not successful", Routes.LoginRoute, loginParameters);
            }

            _cookieContainer.Add(new Uri(Routes.BaseUrl), new Cookie(Parameters.Account.TokenCookieName, loginResponse.Result.Token));
            return true;
        }
    }
}
