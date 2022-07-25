using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Client
{
    public interface IJodelClient : IDisposable
    {
        Task<bool> LoginAsync(string username, string password);

    }
}
