using System;
using static YourSovereignLedger.Core.OrderEnums;

namespace YourSovereignLedger.Core;

public class CommissionSlot
{
    //guid
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid SaleOrderId { get; set; }
    public Status OrderStatus { get; set; }
    public DateOnly? CommissionDateStarted { get; set; }
    public DateOnly? TargetCompletionDate { get; set; }
    public DateTime CommissionDateLastUpdated { get; set; }
}
