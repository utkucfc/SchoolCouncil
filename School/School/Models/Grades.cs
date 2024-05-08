using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Grades
    {
        [Key]
        public int Id { get; set; }
        public string StdNumber { get; set; }
        public string Course_code { get; set; }
        public double Grade { get; set;}
    }
}
