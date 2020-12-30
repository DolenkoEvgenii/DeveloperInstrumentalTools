using System;
using Database.EFCore.Entities;

namespace WebApplication.EFCore
{
    public class CarModelDto
    {
        public String TypeEngine { get; set; }

        public String Name { get; set; }

        public String Car { get; set; }
    }
}