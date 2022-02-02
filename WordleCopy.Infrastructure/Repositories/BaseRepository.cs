using Microsoft.EntityFrameworkCore;
using WordleCopy.Core;
using WordleCopy.Core.Entities;
using WordleCopy.Core.Interfaces;
using WordleCopy.Core.Interfaces.Repositories;
using WordleCopy.Infrastructure.Data;

namespace WordleCopy.Infrastructure.Repositories;

public class BaseRepository<T> : IRepository<T> where T : class, IEntity
{
    private readonly WordleDbContext _dbContext;

    public BaseRepository(WordleDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await GetAll().FirstOrDefaultAsync(e => e.Id.Equals(id));
    }

    public async Task<IEnumerable<T?>> ListAllAsync()
    {
        return await GetAll().ToListAsync();
    }

    public IQueryable<T> GetAll()
    {
        return _dbContext.Set<T>().AsQueryable();
    }

    public async Task<T?> DeleteAsync(Guid id)
    {
        var entityToDelete = await GetByIdAsync(id);
        if (entityToDelete is null) return null;

        _dbContext.Set<T>().Remove(entityToDelete);       
        await _dbContext.SaveChangesAsync();
        return entityToDelete;
    }

    public async Task<T?> UpdateAsync(T entity)
    {
        var updatedEntry = _dbContext.Set<T>().Update(entity);
        await _dbContext.SaveChangesAsync();
        return updatedEntry.Entity;
    }

    public async Task<T?> AddAsync(T entity)
    {
        var addedEntry = await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return addedEntry.Entity;
    }
}