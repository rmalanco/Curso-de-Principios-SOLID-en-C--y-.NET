using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;

namespace Api.Tests;
public class StudentTest
{
    [Fact]
    public void GetStudent()
    {
        var LogbookMock = new Mock<ILogbook>();
        var studentRepositoryMock = new Mock<IStudentRepository>();
        studentRepositoryMock.Setup(p => p.GetAll())
                                        .Returns(new List<Student>()
                                        {
                                            new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                                            new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                                            new Student(3, "José Molina", new List<double>() { 2, 3 })
                                        });

        var studentController = new StudentController(studentRepositoryMock.Object, LogbookMock.Object);

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

    [Fact]
    public void Add()
    {
        var LogbookMock = new Mock<ILogbook>();
        var studentRepositoryMock = new Mock<IStudentRepository>();
        var studentController = new StudentController(studentRepositoryMock.Object, LogbookMock.Object);
        var student = new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 });
        studentController.Add(student);
        studentRepositoryMock.Verify(p => p.Add(student), Times.Once);
        LogbookMock.Verify(p => p.Add($"The Student {student.FullName} have been added"), Times.Once);
    }
}