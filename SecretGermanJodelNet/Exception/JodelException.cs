using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Exception
{
    public class JodelException : System.Exception
    {
        public string Route { get; private set; }
        public Dictionary<string, string> FormParameters { get; private set; }

        public JodelException(string message, string route, Dictionary<string, string> formParameters) : base(message)
        {
            Route = route;
            FormParameters = formParameters;
        }
    }
}
