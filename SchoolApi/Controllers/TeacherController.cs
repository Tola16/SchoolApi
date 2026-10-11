using Microsoft.AspNetCore.Mvc;
using SchoolApi.Dtos;
using SchoolApi.Models;
using SchoolApi.UnitOfWorks;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        public TeacherController(IUnitOfWork of)
        {
            _context = of;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            var a = await _context.Teachers.GetAllAsync();
            var s = a.Select(a => new
            {
                a.Id,
                a.HireDate,
                a.Phone,
                a.FullName,
                a.Email

            });
            return Ok(s);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeacher(CreateTeacherDto dto)
        {
            var a = new Teacher
            {
                HireDate = dto.HireDate,
                Phone = dto.Phone,
                FullName = dto.FullName,
                Email = dto.Email,
            };
            await _context.Teachers.CreateAsync(a);
            await _context.SaveAsync();
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTeacher(int id,CreateTeacherDto dto)
        {
            var a = await _context.Teachers.GetByIdAsync(id);

            a.HireDate = dto.HireDate;
                a.Phone = dto.Phone;
                a.FullName = dto.FullName;
                a.Email = dto.Email;
            
            await _context.SaveAsync();
            return Created();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            await _context.Teachers.DeleteAsync(id);
            await _context.SaveAsync();
            return Ok();
        }

    }
}
