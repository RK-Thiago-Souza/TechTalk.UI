using System;
using TechTalk.Domain;

namespace TechTalk.Data
{
    public class Repository
    {
        public HelloWorldDTO Get()
        {
            return new HelloWorldDTO()
            {
                ID = new Guid(),
                IsValid = true,
                Message = "Success message"
            };
        }
    }
}
