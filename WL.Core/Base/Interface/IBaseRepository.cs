using System;
using System.Linq.Expressions;
using WL.Core.Result;

namespace WL.Core.Base.Interface;

public interface IBaseRepository<T> where T : class
{
    Task<bool> Add(T entity);
    Task<IEnumerable<T?>> Get(Expression<Func<T, bool>>? expression = null);
    Task<PagedResponse<T>> GetPaged(int page, int take);
    Task<T?> GetById(Guid id);
    Task<bool> Remove(T entity);
    Task<bool> Update(T entity);
    Task<bool> Exist(Guid id);
}