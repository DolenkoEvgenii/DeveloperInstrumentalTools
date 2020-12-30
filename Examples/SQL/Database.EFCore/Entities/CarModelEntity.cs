using System.ComponentModel.DataAnnotations.Schema;

namespace Database.EFCore.Entities
{
    [Table("CarModel")]
    public class CarModelEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string TypeEngine { get; set; }
        
        public CarEntity Car { get; set; }
    }
}