namespace YourSovereignLedger.Core;

public class OrderLineItem
{
    public uint Id { get; set; }
    public uint SaleOrderId { get; set; }
    public uint? CatalogItemId { get; set; }
    public string ItemTitleSpanshot { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Quantity { get; set; }
}
