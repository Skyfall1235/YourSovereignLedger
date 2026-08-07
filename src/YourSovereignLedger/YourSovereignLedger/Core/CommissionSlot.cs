using System;
using static YourSovereignLedger.Core.OrderEnums;

namespace YourSovereignLedger.Core;

public class CommissionSlot
{
    public uint Id { get; set; }
    public uint CustomerId { get; set; }
    public uint SaleOrderId { get; set; }
    public uint QueuePosition { get; set; }
    public Status OrderStatus { get; set; }
    public DateOnly? CommissionDateStarted { get; set; }
    public DateOnly? TargetCompletionDate { get; set; }
    public DateTime CommissionDateLastUpdated { get; set; }
}
