using SchoolApi.AppContext;
using SchoolApi.Models;
using SchoolApi.Repo.Interfaces;

namespace SchoolApi.Repo.Implementations
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        public StudentRepo(AppDbContext c) : base(c)
        {
        }
    }
}
