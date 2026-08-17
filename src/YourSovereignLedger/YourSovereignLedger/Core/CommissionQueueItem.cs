namespace YourSovereignLedger.Core;

public class CommissionQueueItem
{
    //fk to commission slot table
    public uint CommissionSlotId { get; set; }
    public uint QueuePosition { get; set; }
}
