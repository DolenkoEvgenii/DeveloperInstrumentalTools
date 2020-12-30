using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.EFCore.Entities
{
    [Table("Car")]
    public class CarEntity
    {
        public int Id { get; set; }

        public String Name { get; set; }
    }
}