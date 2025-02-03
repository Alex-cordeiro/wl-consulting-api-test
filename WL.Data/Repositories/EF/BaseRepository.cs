using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WL.Core.Base.Interface;
using WL.Core.Result;
using WL.Data.Contexts;
using WL.Domain.Entities;

namespace WL.Data.Repositories.EF;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private DefaultContext _context;
    private DbSet<T> _dbSet;

    public BaseRepository(DefaultContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<bool> Add(T entity)
    {
        try
        {
            await _dbSet.AddAsync(entity);

            return true;
        }catch
        {
            return false;
        }
    }

    public async Task<bool> Exist(Guid id)
    {
        return await _dbSet.AnyAsync(x => x.Id.Equals(id));
    }

    public async Task<IEnumerable<T?>> Get(Expression<Func<T, bool>>? expression = null)
    {
          if (expression != null)
                return _dbSet.Where(expression).AsQueryable();

            return _dbSet.AsQueryable();
    }

    public Task<T?> GetById(Guid id)
    {
        return _dbSet.FirstOrDefaultAsync<T>(x => x.Id.Equals(id));
    }

    public async Task<PagedResponse<T>> GetPaged(int page, int take)
    {
         var rowCount = _dbSet.Count();
            var pageCount = (decimal)rowCount / take;

            var resultCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * take;

            var resultQuery = _dbSet.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();

            return await Task.FromResult(new PagedResponse<T>()
            {
                CurrentPage = page,
                PageSize = take,
                TotalCount = resultCount,
                Data = resultQuery
            });
    }

    public Task<bool> Remove(T entity)
    {
        try
        {
            _dbSet.Remove(entity);
            return Task.FromResult(true);
        }
        catch
        {
            return Task.FromResult(false);
        }
    }

    public Task<bool> Update(T entity)
    {
        try
        {
            _dbSet.Update(entity);
            return Task.FromResult(true);
        }
        catch
        {
            return Task.FromResult(false);
        }
    }
}
