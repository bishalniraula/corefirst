using System.ComponentModel.DataAnnotations.Schema;

namespace CoreFirst.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
