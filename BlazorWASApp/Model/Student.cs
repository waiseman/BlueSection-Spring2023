using System.ComponentModel.DataAnnotations;

namespace BlazorWASApp.Model
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50 , ErrorMessage ="name limit exceeds ",MinimumLength =5)]
        public string Name { get; set; }
        
        public string RollNumber { get; set; }
        
        public DateTime DOB { get; set; }

    }
}
