using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentManagentSystem_291225_.Interfaces;
using studentManagentSystem_291225_.Models;

namespace studentManagentSystem_291225_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentSerivce serivce;

        public StudentController(IStudentSerivce serivce)
        {
            this.serivce = serivce;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            var createStudent = await serivce.AddStudent(student);
            return Ok(createStudent);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await serivce.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await serivce.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetStudentByName(string name)
        {
            var student = await serivce.GetStudentByName(name);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest("ID mismatch");
            }
            await serivce.UpdateStudent(student);
            return Ok("Student Updated successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await serivce.DeleteStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

    }
}