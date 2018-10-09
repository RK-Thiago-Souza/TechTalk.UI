using TechTalk.Data;
using TechTalk.Domain;

namespace TechTalk.Service
{
    public class HelloWorldService
    {
        public HelloWorldDTO Get()
        {
            return new Repository().Get();
        }
    }
}
