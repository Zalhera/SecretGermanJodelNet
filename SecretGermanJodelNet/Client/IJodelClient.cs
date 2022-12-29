using SecretGermanJodelNet.Models;

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
        /// <returns></returns>
        Task<JodelResponseBase<AccountInfoResponse>?> GetAccountInfoAsync();
        /// <summary>
        /// Get notifications of currently logged in user
        /// </summary>
        /// <returns></returns>
        Task<JodelResponseBase<NotificationResponse>?> GetNotificationsAsync();
        /// <summary>
        /// Get jodels
        /// </summary>
        /// <param name="sort">Jodel sort</param>
        /// <param name="page">Jodel page (20 posts per Page)</param>
        /// <returns></returns>
        Task<JodelResponseBase<JodelsResponse>?> GetJodelsAsync(JodelSort sort = JodelSort.Newest, int page = 0);
        /// <summary>
        /// Get specific jodel
        /// </summary>
        /// <param name="jodelId">Id of jodel</param>
        /// <returns></returns>
        Task<JodelResponseBase<JodelResponse>?> GetJodelAsync(int jodelId);
        /// <summary>
        /// Load comment for specific jodel
        /// </summary>
        /// <param name="jodelId">Id of jodel to load comments from</param>
        /// <param name="lastCommentId">Get all comments after this comment (0 = get all)</param>
        /// <param name="loadJodel">Load full jodel</param>
        /// <returns></returns>
        Task<JodelResponseBase<CommentResponse>?> GetCommentsAsync(int jodelId, int lastCommentId = 0, bool loadJodel = true);
        /// <summary>
        /// Load new comments of jodel
        /// </summary>
        /// <param name="jodelId">Jodel Id</param>
        /// <param name="lastCommentId">Id of last comment</param>
        /// <returns></returns>
        Task<JodelResponseBase<NewCommentResponse>?> GetNewCommentsAsync(int jodelId, int lastCommentId);
        /// <summary>
        /// Create vote for jodel
        /// </summary>
        /// <param name="jodelId">Id of jodel to create vote for</param>
        /// <param name="vote">Vote direction</param>
        /// <returns></returns>
        Task<JodelResponseBase<JodelVoteResponse>?> VoteJodelAsync(int jodelId, Vote vote);
        /// <summary>
        /// Create vote for comment
        /// </summary>
        /// <param name="commentId">Id of comment to create vote for</param>
        /// <param name="vote">Vote direction</param>
        /// <returns></returns>
        Task<JodelResponseBase<CommentVoteResponse>?> VoteCommentAsync(int commentId, Vote vote);
        /// <summary>
        /// Favor specific jodel
        /// </summary>
        /// <param name="jodelId">Jodel to favor</param>
        /// <returns></returns>
        Task<JodelResponseBase<FavResponse>?> FavorJodelAsync(int jodelId);
        /// <summary>
        /// Unfavor specific jodel
        /// </summary>
        /// <param name="jodelId">Jodel to unfavor</param>
        /// <returns></returns>
        Task<JodelResponseBase<FavResponse>?> UnfavorJodelAsync(int jodelId);
    }
}
