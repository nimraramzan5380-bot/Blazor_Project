using System.ComponentModel.DataAnnotations;

namespace StudentCRUDapp.Model
{
    public class Student
    {
        public int  ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [Range (1,100)]
        public int? Age { get; set; }

        [Required]
        public string? Course { get; set; }
    }
}
