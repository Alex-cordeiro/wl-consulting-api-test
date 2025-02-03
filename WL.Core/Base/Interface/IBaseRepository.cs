using System;
using System.Linq.Expressions;
using WL.Core.Result;

namespace WL.Core.Base.Interface;

public interface IBaseRepository<T> where T : class
{
    Task<T?> Add(T entity);
    Task<IList<T?>> Get(Expression<Func<T, bool>>? expression = null);
    Task<PagesResponse<T>> GetPaged(int page, int take);
    Task<T?> GetById(Guid id);
    Task<bool> Remove(Guid id);
    Task<T?> Update(T entity);
    Task<bool> Exist(Guid id);
}