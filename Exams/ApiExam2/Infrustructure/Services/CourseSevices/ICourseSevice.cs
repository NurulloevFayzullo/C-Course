namespace Infrustructure.Services.CourseSevices;
using Domain.Dtos.CourseDtos;
public interface ICourseSevice
{
    Task<List<GetCourseDtos>> GetCourses();
    Task<GetCourseDtos> GetCourseById(int id);
    Task<GetCourseDtos> AddCourse(AddCourseDtos course);
    Task<bool> DeleteCourse(int id);
    Task<GetCourseDtos> UpdateCourse(AddCourseDtos course);
    int GetCoursesCount();
}
