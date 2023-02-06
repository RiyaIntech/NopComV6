using Nop.Core;
using Nop.Plugin.Pickup.PickupInStore.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Plugin.Pickup.PickupInStore.Services
{
    public interface IStorePickupTimeSlotService
    {
        /// <summary>
        ///   Gets a pickup time slot based on pickup point
        /// </summary>
        /// <param name="storePickupPointId"></param>
        /// <returns></returns>
        Task<IPagedList<StorePickupTimeSlot>> GetStorePickupTimeSlotAsync(int storePickupPointId, int pageIndex = 0, int pageSize = int.MaxValue);
        Task InsertStorePickupTimeSlotAsync(StorePickupTimeSlot pickupTimeSlot);
        Task<StorePickupTimeSlot> GetStorePickupTimeSlotAsync(int pickupTimeSlotId);
        Task UpdateStorePickupTimeSlotAsync(StorePickupTimeSlot pickupTimeSlot);
        Task DeleteStorePickupTimeSlotAsync(StorePickupTimeSlot pickupTimeSlot);
        Task<List<StorePickupTimeSlot>> GetAllStorePickupTimeSlotAsync(int storePickupPointId);
    }
}
