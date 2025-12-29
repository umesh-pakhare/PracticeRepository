using studentManagentSystem_291225_.Interfaces;
using studentManagentSystem_291225_.Models;

namespace studentManagentSystem_291225_.Services
{
    public class StudentService : IStudentSerivce
    {
        private readonly IStudentRepository repository;

        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Student> AddStudent(Student student)
        { 
            await repository.AddStudent(student);
            return student;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await repository.GetAllStudents();
        }

        public async Task<Student?>GetStudentById(int id)
        {
            return await repository.GetStudentById(id);
        }

        public async Task<Student> GetStudentByName(string name)
        { 
            return await repository.GetStudentByName(name);
        }

        public async Task<Student>UpdateStudent(Student student)
        {
            return await repository.UpdateStudent(student);
        }

        public async Task<Student?> DeleteStudent(int id)
        {
            return await repository.DeleteStudent(id);
        }
    }
}
