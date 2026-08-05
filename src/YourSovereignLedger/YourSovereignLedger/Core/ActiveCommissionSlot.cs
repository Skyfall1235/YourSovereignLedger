using System;

namespace YourSovereignLedger.Core;

public class CommissionSlot
{
    public uint Id { get; set; }
    public int SlotNumber { get; set; }//keeps track of number of cleared orders, should autoinc
    public DateOnly CommissionDateStarted { get; set; }
    public DateTime CommissionDateLastUpdated { get; set; }
}
