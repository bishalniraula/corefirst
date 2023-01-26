using System.ComponentModel.DataAnnotations;

namespace CoreFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Name is compulsary")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender is complusary")]
        public Gender Gender { get; set; }    
        
    }
}
