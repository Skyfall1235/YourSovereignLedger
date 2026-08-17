using System;

namespace YourSovereignLedger.Core;

public class CustomerContactInfo// should be linked to the customers but we can seperate it as a many to 1 situation
{
    public Guid Id { get; set; }//should map to the customer profile
    public Guid CustomerId { get; set; }
    public string PlatformName { get; set; }
    public string ContactString { get; set; }//ENCRYPT THIS
    public bool IsPreferred { get; set; }
}
