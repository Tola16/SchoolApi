using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SchoolApi.AppContext;
using SchoolApi.Repo.Interfaces;

namespace SchoolApi.Repo.Implementations
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepo(AppDbContext c )
        {
            _context = c;
        }
        public async Task CreateAsync(T item)
        {
            await _context.AddAsync(item);
        }

        public async Task DeleteAsync(T id)
        {
            var a = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(a);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
