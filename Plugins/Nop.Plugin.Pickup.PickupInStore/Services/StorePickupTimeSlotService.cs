using Nop.Core;
using Nop.Data;
using Nop.Plugin.Pickup.PickupInStore.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Pickup.PickupInStore.Services
{
    public class StorePickupTimeSlotService : IStorePickupTimeSlotService
    {
        #region Fields

        private readonly IRepository<StorePickupTimeSlot> _storePickupTimeSlotRepository;

        #endregion
        public StorePickupTimeSlotService(IRepository<StorePickupTimeSlot> storePickupTimeSlotRepository)
        {
            _storePickupTimeSlotRepository = storePickupTimeSlotRepository;
        }

        #region Methods
        public virtual async Task InsertStorePickupTimeSlotAsync(StorePickupTimeSlot pickupTimeSlot)
        {
            await _storePickupTimeSlotRepository.InsertAsync(pickupTimeSlot, false);
        }
        public virtual async Task<StorePickupTimeSlot> GetStorePickupTimeSlotAsync(int pickupTimeSlotId)
        {
            return await _storePickupTimeSlotRepository.GetByIdAsync(pickupTimeSlotId);
        }
        public virtual async Task UpdateStorePickupTimeSlotAsync(StorePickupTimeSlot pickupTimeSlot)
        {
            await _storePickupTimeSlotRepository.UpdateAsync(pickupTimeSlot, false);
        }
        public virtual async Task DeleteStorePickupTimeSlotAsync(StorePickupTimeSlot pickupTimeSlot)
        {
            await _storePickupTimeSlotRepository.DeleteAsync(pickupTimeSlot, false);
        }

        public virtual async Task<IPagedList<StorePickupTimeSlot>> GetStorePickupTimeSlotAsync(int storePickupPointId, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var rez = await _storePickupTimeSlotRepository.GetAllAsync(query =>
            {
                query = query.Where(point => point.StorePickupPointId == storePickupPointId);
                return query;
            });

            return new PagedList<StorePickupTimeSlot>(rez, pageIndex, pageSize);
            throw new System.NotImplementedException();
        }

        public virtual async Task<List<StorePickupTimeSlot>> GetAllStorePickupTimeSlotAsync(int storePickupPointId)
        {
            var rez = await _storePickupTimeSlotRepository.GetAllAsync(query =>
            {
                query = query.Where(point => point.StorePickupPointId == storePickupPointId && point.Active == true);
                return query;
            });
            return new List<StorePickupTimeSlot>(rez);
        }
        #endregion
    }
}
