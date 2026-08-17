using System;

namespace YourSovereignLedger.Core;

public class OrderLineItem
{
    public Guid Id { get; set; }
    public Guid SaleOrderId { get; set; }
    public Guid? CatalogItemId { get; set; }
    public string ItemTitleSpanshot { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Quantity { get; set; }
}
