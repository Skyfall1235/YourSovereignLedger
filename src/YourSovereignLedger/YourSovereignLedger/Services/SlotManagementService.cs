using System.Collections.Generic;
using YourSovereignLedger.Core;
using YourSovereignLedger.Data.Context;

namespace YourSovereignLedger.Services;
public class SlotManagementService
{
    public readonly List<CommissionSlot> commissionSlots;
    private readonly AppDBContext appDBContext;
    //this class should handle management of the commissiohn slot management pages
    public void UpdateQueue() { }
    public void MoveSlotToNewPosition() { }
    public void RefreshCache()
    {
        //appDBContext.
    }
}
