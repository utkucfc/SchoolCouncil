using School.Models;
using Microsoft.AspNetCore.Mvc;


namespace School.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentGradeController : ControllerBase
    {
        private readonly Context _db;
        public StudentGradeController(Context context)
        {
            context.Database.EnsureCreated();
            _db = context;
        }

        [HttpPost(Name = "PostStudent")]
        public string PostProduct(PostData postData)
        {
            Students students = new Students();
            students.Name = postData.Name;
            students.Surname = postData.Surname;
            students.StdNumber = postData.StdNumber;

            foreach (var grade in postData.Grades)
            {
                var prevGrade = _db.Grades.FirstOrDefault(t => t.StdNumber == postData.StdNumber && t.Course_code == grade.Course_code);
                if (prevGrade != default)
                {
                    prevGrade.Grade = (prevGrade.Grade + grade.value) / 2;
                }
                else
                {
                    Grades grades = new Grades();
                    grades.StdNumber = students.StdNumber;
                    grades.Course_code = grade.Course_code;
                    grades.Grade = grade.value;
                    _db.Add(grades);
                }
            }
            _db.Add(students);
            _db.SaveChanges();
            return "200 OK";
        }
    }
}
 