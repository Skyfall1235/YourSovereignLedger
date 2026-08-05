using static YourSovereignLedger.Core.OrderEnums;

namespace YourSovereignLedger.Core;
public class CatalogItem
{
    public uint Id { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public OrderType ProductCategory { get; set; }
    public decimal ProductPrice { get; set; }
    public FulfillmentCategory FulfillmentStatus { get; set; }
}
