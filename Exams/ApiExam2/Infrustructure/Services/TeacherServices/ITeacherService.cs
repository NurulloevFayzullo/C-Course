namespace Infrustructure.Services.TeacherServices;
using Domain.Dtos.TeacherDtos;
public interface ITeacherService
{
    Task<List<GetTeacherDtos>> GetTeachers();
    Task<GetTeacherDtos> GetTeacherById(int id);
    Task<GetTeacherDtos> AddTeacher(AddTeacherDtos teacher);
    Task<bool> DeleteTeacher(int id);
    Task<GetTeacherDtos> UpdateTeacher(AddTeacherDtos teacher);
    int GetTeachersCount();
}
