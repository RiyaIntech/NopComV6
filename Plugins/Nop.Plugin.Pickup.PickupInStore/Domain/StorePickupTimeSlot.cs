using Nop.Core;

namespace Nop.Plugin.Pickup.PickupInStore.Domain
{
    public class StorePickupTimeSlot : BaseEntity
    {
        public int StorePickupPointId { get; set; }
        public string TimeSlot { get; set; }
        public int? LimitOrderPerTimeSlot { get; set; }
        public bool Active { get; set; }
    }
}
