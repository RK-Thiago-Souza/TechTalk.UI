using TechTalk.Service;
using Xunit;

namespace TechTalk.Tests
{
    public class HelloWorldTest
    {
        [Fact]
        public void GetValid()
        {
            var helloWorld = new HelloWorldService().Get();
            Assert.True(helloWorld.IsValid);
        }
    }
}
