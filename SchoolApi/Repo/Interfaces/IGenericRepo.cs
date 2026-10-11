namespace SchoolApi.Repo.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        Task  CreateAsync(T item);
        void Update(T item);
        Task <ICollection<T>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<T?> GetByIdAsync(int id);

    }
}
