namespace ApplicationTier.Domain.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        
        Task<T> GetByIdAsync(Guid id);

        Task<T> CreateAsync(T item);

        Task<T> UpdateAsync(T item);
        
        Task<T> DeleteAsync(T item);
    }
}