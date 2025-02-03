using WL.Utils.Enums;

namespace WL.Domain.Entities.Wallets;

public class Wallet : BaseEntity
{
    public string Alias { get; set; } = null!;
    public Decimal Amount { get; set; }
    public EConsumingTypeFlag MyProperty { get; set; }
}
