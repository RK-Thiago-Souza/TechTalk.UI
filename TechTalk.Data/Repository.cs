using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.Domain;

namespace TechTalk.Data
{
    public class Repository
    {
        public Repository()
        {
            this.HelloWorlds = new List<HelloWorldDTO>();
            this.Seed();
        }

        public List<HelloWorldDTO> List()
        {
            return this.HelloWorlds.ToList();
        }

        public HelloWorldDTO Get(bool isValid)
        {
            return this.HelloWorlds.Where(o => o.IsValid == isValid).FirstOrDefault();
        }

        private List<HelloWorldDTO> Seed()
        {
            this.HelloWorlds.Add(new HelloWorldDTO
            {
                ID = Guid.NewGuid(),
                IsValid = false,
                Message = "Hello World, funcionara, orem"
            });

            this.HelloWorlds.Add(new HelloWorldDTO
            {
                ID = Guid.NewGuid(),
                IsValid = true,
                Message = "Hello FDTE, teste hoje"
            });

            this.HelloWorlds.Add(new HelloWorldDTO
            {
                ID = Guid.NewGuid(),
                IsValid = true,
                Message = "Hello TechTalk? sera?"
            });

            this.HelloWorlds.Add(new HelloWorldDTO
            {
                ID = Guid.NewGuid(),
                IsValid = true,
                Message = "Hello TechOps!"
            });

            return this.HelloWorlds;
        }

        public List<HelloWorldDTO> HelloWorlds { get; set; }
    }
}
