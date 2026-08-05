namespace YourSovereignLedger.Core;
public static class OrderEnums
{
    public enum OrderType
    {
        Custom, Alteration, LineItem
    }
    public enum ContactType
    {
        Discord, Instagram, Phone, Email, Twitter, X,
    }

    public enum FulfillmentCategory
    {
        ReadyMade, CustomCommission, Alteration, Digital
    }
}
