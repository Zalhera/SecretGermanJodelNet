using SecretGermanJodelNet.Constants;
using SecretGermanJodelNet.Converter;
using SecretGermanJodelNet.Models;
using System.Net;
using System.Text.Json;

namespace SecretGermanJodelNet.Client
{
    public sealed class JodelClient : IJodelClient
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _handler;
        private readonly CookieContainer _cookieContainer;

        private static readonly JsonSerializerOptions _jsonSerialzerOptions = new JsonSerializerOptions()
        {
            Converters =
            {
                new UnixTimestampConverter()
            },
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
        };

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

        private async Task<JodelResponseBase<T>?> PostAsync<T>(string url, HttpContent? content = null)
            where T : class
        {
            using (var response = await _httpClient.PostAsync(url, content))
            {
                if (!response.IsSuccessStatusCode)
                {
                    return default;
                }

                return JsonSerializer.Deserialize<JodelResponseBase<T>>(await response.Content.ReadAsStringAsync(), _jsonSerialzerOptions);
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
        public async Task<JodelResponseBase<AccountInfoResponse>?> GetAccountInfoAsync()
        {
            var accountInfoFormData = new FormUrlEncodedContent(new Dictionary<string, string>() { { Parameters.FullFormName, "1" } });
            return await PostAsync<AccountInfoResponse>(Routes.InfoRoute, accountInfoFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<NotificationResponse>?> GetNotificationsAsync()
        {
            return await PostAsync<NotificationResponse>(Routes.NotificationsRoute);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<JodelResponse>?> GetJodelAsync(int jodelId)
        {
            var jodelFormData = new FormUrlEncodedContent(new Dictionary<string, string>() { { Parameters.IdFormName, jodelId.ToString() } });
            return await PostAsync<JodelResponse>(Routes.JodelRoute, jodelFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<JodelsResponse>?> GetJodelsAsync(JodelSort jodelSort = JodelSort.Newest, int page = 0)
        {
            var jodelParameters = new Dictionary<string, string>()
            {
                { Parameters.SortFormName, ((int)jodelSort).ToString() },
                { Parameters.AmountFormName, page.ToString() },
            };

            var jodelsFormData = new FormUrlEncodedContent(jodelParameters);
            return await PostAsync<JodelsResponse>(Routes.JodelsRoute, jodelsFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<CommentResponse>?> GetCommentsAsync(int jodelId, int lastCommentId = 0, bool loadJodel = true)
        {
            var commentParameters = new Dictionary<string, string>()
            {
                { Parameters.IdFormName, jodelId.ToString() },
                { Parameters.DirectionFormName, "1" },
                { Parameters.LastIdFormName, lastCommentId.ToString() },
                { Parameters.CommentIdFormName, "0" },
                { Parameters.JodelNeededFormName, loadJodel ? "1" : "0" },
                { Parameters.NotificationIdFormName, "0" },
                { Parameters.SpecialFormName, "0" },
                { Parameters.ViewFormName, "1" },
            };

            var commentsFormData = new FormUrlEncodedContent(commentParameters);
            return await PostAsync<CommentResponse>(Routes.CommentsRoute, commentsFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<NewCommentResponse>?> GetNewCommentsAsync(int jodelId, int lastCommentId)
        {
            var newCommentParameters = new Dictionary<string, string>()
            {
                { Parameters.IdFormName, jodelId.ToString() },
                { Parameters.LastIdFormName, lastCommentId.ToString() },
            };

            var newCommentsFormData = new FormUrlEncodedContent(newCommentParameters);
            return await PostAsync<NewCommentResponse>(Routes.NewCommentsRoute, newCommentsFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<JodelVoteResponse>?> VoteJodelAsync(int jodelId, Vote vote)
        {
            var voteJodelParameters = new Dictionary<string, string>()
            {
                { Parameters.IdFormName, jodelId.ToString() },
                { Parameters.VoteFormName, ((int)vote).ToString() },
                { Parameters.TypeFormName, "0" },
            };

            var voteJodelFormData = new FormUrlEncodedContent(voteJodelParameters);
            return await PostAsync<JodelVoteResponse>(Routes.CreateVoteRoute, voteJodelFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<CommentVoteResponse>?> VoteCommentAsync(int commentId, Vote vote)
        {
            var voteCommentParameters = new Dictionary<string, string>()
            {
                { Parameters.IdFormName, commentId.ToString() },
                { Parameters.VoteFormName, ((int)vote).ToString() },
                { Parameters.TypeFormName, "1" },
                { Parameters.UserAuthorFormName, "0" },
                { Parameters.UserAuthorCommentFormName, "0" },
            };

            var voteCommentFormData = new FormUrlEncodedContent(voteCommentParameters);
            return await PostAsync<CommentVoteResponse>(Routes.CreateVoteRoute, voteCommentFormData);
        }

        private async Task<JodelResponseBase<FavResponse>?> FavorUnfavorJodelAsync(int jodelId, Favor favor)
        {
            var jodelFavorParameters = new Dictionary<string, string>()
            {
                { Parameters.IdFormName, jodelId.ToString() },
                { Parameters.FavFormName, ((int)favor).ToString() },
            };

            var jodelFavorFormData = new FormUrlEncodedContent(jodelFavorParameters);
            return await PostAsync<FavResponse>(Routes.FavorRoute, jodelFavorFormData);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<FavResponse>?> FavorJodelAsync(int jodelId)
        {
            return await FavorUnfavorJodelAsync(jodelId, Favor.Favor);
        }

        /// <inheritdoc/>
        public async Task<JodelResponseBase<FavResponse>?> UnfavorJodelAsync(int jodelId)
        {
            return await FavorUnfavorJodelAsync(jodelId, Favor.Unfavor);
        }
    }
}
