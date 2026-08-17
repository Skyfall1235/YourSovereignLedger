using System;

namespace YourSovereignLedger.Core;
public class CustomerProfile
{
    public Guid Id { get; set; }
    public DateOnly CustomerJoinedDate { get; set; }
}
