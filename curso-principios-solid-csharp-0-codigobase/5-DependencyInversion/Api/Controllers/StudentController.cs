using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    // readonly StudentRepository studentRepository = new();
    // readonly Logbook logbook = new();

    readonly IStudentRepository studentRepository;
    readonly ILogbook logbook;
    public StudentController(IStudentRepository student, ILogbook log)
    {
        studentRepository = student;
        logbook = log;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add("returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody] Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.FullName} have been added");
    }
}
