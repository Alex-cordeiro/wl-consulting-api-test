using WL.Core.Result;

namespace WL.Core.Base.Interface;

public interface IBaseAppService<TCreateCommand, TUpdateCommand, TPagedCommand, TPagedResponse, TResponseView>
    where TCreateCommand: class
    where TUpdateCommand: class
    where TPagedCommand: class
    where TPagedResponse: class
    where TResponseView: class
{
    Task<ResponseResult> Create(TCreateCommand entityCreate);
    Task<ResponseResult> Update(TUpdateCommand entityUpdate);
    Task<ResponseResult<TResponseView>> GetById(Guid id);
    Task<ResponseResult> Delete(Guid id);
}
