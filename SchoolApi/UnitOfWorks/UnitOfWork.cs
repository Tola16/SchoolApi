using Azure.Core.Pipeline;
using Microsoft.Identity.Client;
using SchoolApi.AppContext;
using SchoolApi.Repo.Interfaces;

namespace SchoolApi.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public ITeacherRepo Teachers { get; }

        public IStudentRepo Students { get; }

        public UnitOfWork(ITeacherRepo repo,AppDbContext appDbContext , IStudentRepo student)
        {
            Teachers = repo;
            _context = appDbContext;
            Students = student;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
