using FluentAssertions;

namespace SecretGermanJodelNetTests
{
    public class JodelClientTests : JodelTestBase
    {
        [Fact]
        public async Task GetAccountInfoAsync_ReturnValidAccountInfo()
        {
            var result = await JodelClient.GetAccountInfoAsync();

            result.Should().NotBeNull();
            result!.StatusId.Should().Be(1);
            result.Result.Should().NotBeNull();
            result.Result!.Account.Should().NotBeNull();
            result.Result.Account!.Donator.Should().NotBeNull();
            result.Result.Account.Entrycodes.Should().NotBeNull();
            result.Result.Account.Entrycodes!.Info.Should().NotBeNull();
            result.Result.Account.Feels.Should().NotBeNull();
            result.Result.Account.Gender.Should().NotBeNull();
            result.Result.Account.Notifications.Should().NotBeNull();
            result.Result.Account.Premium.Should().NotBeNull();
            result.Result.Account.Settings.Should().NotBeNull();
            result.Result.Js.Should().NotBeNull();
        }

        [Fact]
        public async Task GetNotificationsAsync_ReturnValidNotifications()
        {
            var result = await JodelClient.GetNotificationsAsync();

            result.Should().NotBeNull();
            result!.StatusId.Should().Be(1);
            result.Result.Should().NotBeNull();
            result.Result!.Notifications.Should().NotBeNull();
        }

        [Fact]
        public async Task GetJodelsAsync_ReturnValidJodels()
        {
            var result = await JodelClient.GetJodelsAsync();

            result.Should().NotBeNull();
            result!.StatusId!.Should().Be(1);
            result.Result.Should().NotBeNull();
            result.Result!.Jodels.Should().NotBeNull();
            result.Result!.View.Should().NotBeNull();
        }

        [Fact]
        public async Task GetJodelAsync_ReturnValidJodel()
        {
            var jodelId = int.Parse(Configuration.GetSection("jodelId").Value!);
            var result = await JodelClient.GetJodelAsync(jodelId);

            result.Should().NotBeNull();
            result!.StatusId.Should().Be(1);
            result.Result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetCommentsAsync_ReturnValidComments()
        {
            var jodelId = int.Parse(Configuration.GetSection("jodelId").Value!);
            var result = await JodelClient.GetCommentsAsync(jodelId);

            result.Should().NotBeNull();
            result!.StatusId.Should().Be(1);
            result.Result.Should().NotBeNull();
            result.Result!.Comments.Should().NotBeNull();
            result.Result!.Jodel.Should().NotBeNull();
        }
    }
}
