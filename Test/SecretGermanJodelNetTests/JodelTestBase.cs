using FluentAssertions;
using Microsoft.Extensions.Configuration;
using SecretGermanJodelNet.Client;

namespace SecretGermanJodelNetTests
{
    public abstract class JodelTestBase : IDisposable
    {
        protected readonly IConfigurationRoot Configuration;
        protected readonly string Username;
        protected readonly string Password;
        protected readonly string SessionCookie;
        protected readonly IJodelClient JodelClient;

        protected JodelTestBase()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Username = Configuration.GetSection("username").Value!;
            Password = Configuration.GetSection("password").Value!;
            SessionCookie = Configuration.GetSection("sessioncookie").Value!;

            if (string.IsNullOrEmpty(SessionCookie))
            {
                if (string.IsNullOrEmpty(Username))
                    Assert.Fail("No username set");

                if (string.IsNullOrEmpty(Password))
                    Assert.Fail("No password set");
            }

            JodelClient = new JodelClient();

            if (!string.IsNullOrEmpty(SessionCookie))
            {
                JodelClient.SetSessionCookie(SessionCookie);
            }
            else
            {
                var loginResult = JodelClient.LoginAsync(Username, Password).Result;
                loginResult.Should().BeTrue();
            }
        }

        public void Dispose()
        {
            JodelClient?.Dispose();
        }
    }
}
