using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WL.Data.Contexts;

public class DefaultContext : DbContext
{
    private readonly IHttpContextAccessor _httpContextAcessor;

    public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
    {
    }

     

}
