using TechTalk.Service;
using Xunit;

namespace TechTalk.Tests
{
    public class HelloWorldTest
    {
        [Fact]
        public void GetValid()
        {
            var helloWorld = HelloWorldService.Get(true);
            Assert.True(helloWorld.IsValid);
        }

        [Fact]
        public void GetInvalid()
        {
            var helloWorld = HelloWorldService.Get(false);
            Assert.False(helloWorld.IsValid);
        }

        [Fact]
        public void ListSuccess()
        {
            var helloWorlds = HelloWorldService.List();
            var hasRow = helloWorlds.Count > 0 ? true : false;

            Assert.True(hasRow);
        }
    }
}
