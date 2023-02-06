using Nop.Web.Framework.Models;

namespace Nop.Plugin.Pickup.PickupInStore.Models
{
    public record StorePickupTimeSlotSearchModel : BaseSearchModel
    {
        public int StorePickupPointId { get; set; }
    }
}
