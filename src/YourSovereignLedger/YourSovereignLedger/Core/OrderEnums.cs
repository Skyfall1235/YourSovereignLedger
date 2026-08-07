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
        Queue, InProgress, ClientReview, Approved, Delivered, Canceled
    }
}
