using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class PostData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StdNumber { get; set; }
        public List<Grade> Grades { get; set; }
    }
    public class Grade
    {
        public string code { get; set; }
        public double value{ get; set; }
    }
}
