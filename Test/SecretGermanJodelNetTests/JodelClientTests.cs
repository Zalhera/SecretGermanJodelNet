namespace SecretGermanJodelNetTests
{
    public class JodelClientTests : JodelTestBase
    {
        [Fact]
        public async Task GetAccountInfo_ReturnValidAccountInfo()
        {
            var result = await JodelClient.GetAccountInfo();
        }
    }
}
