namespace YourSovereignLedger.Core;
public static class OrderEnums
{
    public enum OrderType
    {
        ReadyMade, CustomCommission, Alteration, Digital
    }
    public enum PaymentStatus
    {
        Pending, DepositPaid, FullyPaid, Refunded
    }
    public enum Status
    {
        Queue = 1,
        InProgress = 2,
        ClientReview = 3,
        Approved = 4,
        Delivered = 5,
        Canceled = 0
    }
}
