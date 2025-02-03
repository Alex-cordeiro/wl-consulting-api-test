using System;

namespace WL.Core.Result;

public class PagesResponse<T> where T : class
{
    public int CurrentPage { get; set; }
    public int TotalCount { get; set; }
    public int PageSize { get; set; }
    public List<T> Data { get; set; } = new List<T>();
}
