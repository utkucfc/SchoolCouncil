using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }    
        public string Surname { get; set; }
        public string StdNumber { get; set; }

    }
}
