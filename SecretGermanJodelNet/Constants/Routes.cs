using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Constants
{
    public static class Routes
    {
        public const string BaseUrl = "https://secretgermanjodel.com";
        public const string ApiBaseUrl = "https://secretgermanjodel.com/api/";

        public const string LoginRoute = "auth/login";
        public const string JodelsRoute = "jodels/get";

        public const string CommentsRoute = "comments/get";
        public const string NewCommentsRoute = "comments/new";
    }
}
