using System.Collections.Generic;
using TechTalk.Data;
using TechTalk.Domain;

namespace TechTalk.Service
{
    public static class HelloWorldService
    {
        public static HelloWorldDTO Get(bool isValid)
        {
            return new Repository().Get(isValid);
        }

        public static List<HelloWorldDTO> List()
        {
            return new Repository().List();
        }
    }
}
