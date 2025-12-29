using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using studentManagentSystem_291225_.Data;
using studentManagentSystem_291225_.Interfaces;
using studentManagentSystem_291225_.Models;

namespace studentManagentSystem_291225_.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext context;

        public StudentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Student>AddStudent(Student student)
        { 
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await context.Students.ToListAsync();
        }

        public async Task<Student?>GetStudentById(int id)
        {            
            return await context.Students.FindAsync(id);
        }

        public async Task<Student> GetStudentByName(string name)
        {
            // return await context.Students.FindAsync(name);
            return await context.Students
                    .FirstOrDefaultAsync(s => s.Name == name);
        }

        public async Task<Student>UpdateStudent(Student student)
        {
            context.Students.Update(student);
            await context.SaveChangesAsync();
            return student;
        }

        public async Task<Student?> DeleteStudent(int id)
        {
            var student = await context.Students.FindAsync(id);
            if(student == null)
            {
                return null;
            }
            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return student;
        }


    }
}

