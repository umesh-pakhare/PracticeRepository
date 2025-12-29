using studentManagentSystem_291225_.Models;

namespace studentManagentSystem_291225_.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student>AddStudent(Student student);
        Task<List<Student>> GetAllStudents();
        Task<Student?> GetStudentById(int id);
        Task<Student>GetStudentByName(string name);
        Task<Student> UpdateStudent(Student student);
        Task<Student?> DeleteStudent(int id);

    }
}
    