using System.ComponentModel;

namespace WL.Utils.Enums;

public enum EConsumingTypeFlag
{
    [Description("Alimentação")]
    Alimentação,
    [Description("Abastecimento")]
    Gas,
    [Description("Estacionamento")]
    Parking,
    [Description("Cinema")]
    Cinema
}
