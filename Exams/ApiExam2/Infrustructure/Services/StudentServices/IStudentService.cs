using Domain.Dtos.StudentDtos;

namespace Infrustructure.Services.StudentServices;

public interface IStudentService
{
    Task<List<GetStudentDtos>> GetStudents();
    Task<GetStudentDtos> GetStudentById(int id);
    Task<GetStudentDtos> AddStudent(AddStudentDtos student);
    Task<bool> DeleteStudent(int id);
    Task<GetStudentDtos> UpdateStudent(AddStudentDtos student);
    int GetStudentsCount();
}
