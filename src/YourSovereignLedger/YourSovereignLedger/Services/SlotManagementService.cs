using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourSovereignLedger.Core;
using YourSovereignLedger.Data.Context;

namespace YourSovereignLedger.Services;
public class SlotManagementService
{
    public List<CommissionSlot> CommissionSlots
    { get; private set; }

    private readonly AppDBContext appDBContext;
    //this class should handle management of the commissiohn slot management pages
    public void UpdateQueue() { }
    public async void MoveSlotToNewPosition(int ItemIndex, int NewIndex)
    {
        //just update the DB and then refresh the cache
        await UpdateSlotPositioninDb(ItemIndex, NewIndex);
        await RefreshCache();
    }
    public async Task RefreshCache()
    {
        CommissionSlots.Clear();
        CommissionSlots = await appDBContext.CommissionSlots
        .Where(slot => slot.OrderStatus == OrderEnums.Status.Queue || slot.OrderStatus == OrderEnums.Status.InProgress)
        .OrderBy(slot => slot.QueuePosition)
        .ToListAsync();
    }
    private async Task UpdateSlotPositioninDb(int ItemIndex, int NewIndex)
    {
        //get the current object and then we need to update all the objects after it to bump ++
        //we need
        //-item row we are moving. whatever the current item we want to shift around.
        //-the item we want to uinsert this after. so if we insert this into index 3, we need to get index 2 to redo the link.
        //-the id of the item after the pre insert index. this is so we can insert into the linked list.
        //we can probably get this from the OLD ITEM AT THIS INDEX!

        //if we are movign osmething to the end, we can just wipe the pointerId and be done.

    }
    //USE A LINKLED LIST TO KEEP TRACK OF THE NEXT IN LINE

}
