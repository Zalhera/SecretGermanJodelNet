namespace SecretGermanJodelNet.Client
{
    public interface IJodelClient : IDisposable
    {
        Task<bool> LoginAsync(string username, string password);

    }
}
