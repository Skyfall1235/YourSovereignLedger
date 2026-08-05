using System;
using static YourSovereignLedger.Core.OrderEnums;

namespace YourSovereignLedger.Core;
public class CustomerProfile
{
    public uint Id { get; set; }
    public DateOnly CustomerJoinedDate { get; set; }
    public string CustomerName { get; set; }
}

public class CustomerContactInfo// should be linked to the customers but we can seperate it as a many to 1 situation
{
    public uint uId { get; set; }//should map to the customer profile
    public uint Customerid { get; set; }
    public ContactType CustomerContactType { get; set; }
    public string ContactString { get; set; }
    public bool IsPreferred { get; set; }
}
