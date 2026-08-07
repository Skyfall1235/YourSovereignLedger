using YourSovereignLedger.Data.Context;

namespace YourSovereignLedger.Services;

public class OrderManagementService
{
    private readonly AppDBContext _dbContext;

    public void CreateOrder() { }
    public void DeleteOrder() { }
    public void UpdateOrder() { }

    public void AddProgressPhoto() { }
    public void AddBulkProgressPhotos() { }
    public void DownloadProgessPhotos() { }
    public void RetrieveProgressPhotos() { }

    public void AddLineItem() { }
    public void AddCustomItem() { }
    public void UpdateLineItem() { }
    public void DeleteLineItem() { }

}
