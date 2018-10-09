using System;

namespace TechTalk.Domain
{
    public class HelloWorldDTO
    {
        public Guid ID { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }
    }
}
