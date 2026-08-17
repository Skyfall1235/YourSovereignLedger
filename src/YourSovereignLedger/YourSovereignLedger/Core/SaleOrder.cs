using System;
using static YourSovereignLedger.Core.OrderEnums;

namespace YourSovereignLedger.Core;
public class SaleOrder
{
    public Guid Id { get; set; }
    public uint CustomerId { get; set; }
    public DateTimeOffset DateTimeOrdered { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public decimal TotalAmount { get; set; }
}
