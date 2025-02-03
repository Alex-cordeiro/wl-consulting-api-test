using WL.Domain.Entities;
using WL.Domain.Entities.Users;

namespace WL.Domain.Transactions;

public class Transaction : BaseEntity
{
    public Decimal Value { get; set; }
    public DateTime DateTransaction { get; set; }
    public Guid UserIdSender { get; set; }
    public Guid UserId { get; set; }
    public virtual User MyProperty { get; set; } = new();
}
