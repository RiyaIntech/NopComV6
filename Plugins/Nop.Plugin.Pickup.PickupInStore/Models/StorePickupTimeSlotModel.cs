using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Pickup.PickupInStore.Models
{
    public record StorePickupTimeSlotModel : BaseNopEntityModel
    {
        public StorePickupTimeSlotModel()
        {

        }
        [NopResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.LimitOrderPerTimeSlot")]
        public int LimitOrderPerTimeSlot { get; set; }

        [NopResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.TimeSlot")]
        public string TimeSlot { get; set; }

        [NopResourceDisplayName("Plugins.Pickup.PickupInStore.Fields.Active")]
        public bool Active { get; set; }
        public int StorePickupPointId { get; set; }

        // public StorePickupTimeSlotSearchModel StorePickupTimeSlotSearchModel { get; set; }
    }
}
