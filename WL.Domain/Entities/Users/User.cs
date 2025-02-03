using System;
using WL.Domain.Entities.Wallets;

namespace WL.Domain.Entities.Users;

public class User : BaseEntity
{
    public string Name { get; private set; } = null!;
    public DateTime BirthDate { get; private set; }
    public string UserName { get; private set; } = null!;
    public string Password { get; private set; } = null!;

    public virtual IList<Wallet> Wallets { get; private set; } = null!;
}
