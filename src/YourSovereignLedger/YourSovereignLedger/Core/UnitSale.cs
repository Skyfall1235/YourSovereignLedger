using System;

namespace YourSovereignLedger.Core;
public class UnitSale
{
    public uint Id { get; set; }
    public CustomerProfile Customer { get; set; } = null;
    public DateTime DateTimeOrdered { get; set; }

    public uint LineItemId { get; set; }//null if none
    public decimal SalePrice { get; set; }//at time of sale, pretax
    public uint Amount { get; set; } //of this item sold

}
