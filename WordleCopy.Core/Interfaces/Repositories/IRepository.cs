namespace WordleCopy.Core.Interfaces.Repositories;

public interface IRepository<T> where T : IEntity
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T?>> ListAllAsync();
    IQueryable<T?> GetAll();
    Task<T?> DeleteAsync(Guid id);
    Task<T?> UpdateAsync(T entity);
    Task<T?> AddAsync(T entity);
}