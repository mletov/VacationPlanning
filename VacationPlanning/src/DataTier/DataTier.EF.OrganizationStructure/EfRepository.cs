using ApplicationTier.Domain;
using ApplicationTier.Domain.Interfaces;

using DataTier.EF.OrganizationStructure;

using Microsoft.EntityFrameworkCore;

namespace DataTier.EF.OrganizationStructure
{
    public class EfRepository<T>: IRepository<T> 
        where T:BaseEntity
    {
        private readonly DataContextStruct _dataContext;
        public EfRepository(DataContextStruct dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<T> CreateAsync(T item)
        {
            _dataContext.Add(item);
            _dataContext.SaveChanges();
            return Task.FromResult( item);
          
        }

        public Task<T> UpdateAsync(T entity)
        {
            _dataContext.Update(entity);
            _dataContext.SaveChanges();
            return Task.FromResult( entity);
        }

        public async Task<T> DeleteAsync(T item)
        {
            _dataContext.Remove(item);
            _dataContext.SaveChanges();
            return await Task.FromResult(item);
        }
    }
}