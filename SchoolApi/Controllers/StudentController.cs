using System.Net;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Dtos;
using SchoolApi.Models;
using SchoolApi.UnitOfWorks;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        public StudentController(IUnitOfWork a)
        {
            _context = a; 
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var a = await _context.Students.GetAllAsync();
            var s = a.Select(a => new
            {
                a.Id,
                a.Gender,
                a.DOB,
                a.PhoneNumber,
                a.FullName,
                a.Email

            });
            return Ok(s);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeacher(CreateStudentDto dto)
        {
            var a = new Student
            {

                  DOB = dto.DOB,
                   Gender = dto.Gender, 
                    
                PhoneNumber= dto.PhoneNumber,
                FullName = dto.FullName,
                Email = dto.Email,
            };
            await _context.Students.CreateAsync(a);
            await _context.SaveAsync();
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStudent(int id, CreateStudentDto dto)
        {
            var a = await _context.Students.GetByIdAsync(id);
            a.DOB = dto.DOB;
            a.Gender = dto.Gender;

            a.PhoneNumber = dto.PhoneNumber;
            a.FullName = dto.FullName;
            a.Email = dto.Email;
            await _context.SaveAsync();
            return Created();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await _context.Students.DeleteAsync(id);
            await _context.SaveAsync();
            return Ok();
        }


    }
}
