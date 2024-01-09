namespace FluentResult.Tests
{
    public class FluentResultTest
    {
        [Fact]
        public void When_ResultOk_Then_True()
        {
            var result = Result.Ok();

            Assert.True(result);
        }

        [Fact]
        public void When_ResultFail_Then_False()
        {
            var result = Result.Fail("");

            Assert.False(result);
        }
    }
}