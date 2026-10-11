using System.IO.Pipes;
using SchoolApi.Repo.Interfaces;

namespace SchoolApi.UnitOfWorks
{
    public interface IUnitOfWork
    {
        
        public IStudentRepo Students { get; }
        public ITeacherRepo Teachers { get; }
        Task SaveAsync();


    }
}
