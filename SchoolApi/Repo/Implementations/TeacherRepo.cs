using SchoolApi.AppContext;
using SchoolApi.Models;
using SchoolApi.Repo.Interfaces;

namespace SchoolApi.Repo.Implementations
{
    public class TeacherRepo : GenericRepo<Teacher>, ITeacherRepo
    {
        public TeacherRepo(AppDbContext c) : base(c)
        {
        }
    }
}
