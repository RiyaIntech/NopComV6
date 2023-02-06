using Nop.Plugin.Pickup.PickupInStore.Models;
using System.Threading.Tasks;

namespace Nop.Plugin.Pickup.PickupInStore.Factories
{
    public interface IStorePickupTimeSlotModelFactory
    {
        Task<StorePickupTimeSlotSearchModel> PrepareStorePickuptTimeSlotModelAsync(StorePickupTimeSlotSearchModel searchModel);

        Task<StorePickupTimeSlotListModel> PrepareStorePickupTimeSlotListModelAsync(int storePickUpPointId, StorePickupTimeSlotSearchModel searchModel);
    }
}
