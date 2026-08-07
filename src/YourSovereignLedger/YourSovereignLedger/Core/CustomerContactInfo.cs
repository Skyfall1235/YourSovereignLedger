namespace YourSovereignLedger.Core;

public class CustomerContactInfo// should be linked to the customers but we can seperate it as a many to 1 situation
{
    public uint uId { get; set; }//should map to the customer profile
    public uint Customerid { get; set; }
    public string PlatformName { get; set; }
    public string ContactString { get; set; }//ENCRYPT THIS
    public bool IsPreferred { get; set; }
}
