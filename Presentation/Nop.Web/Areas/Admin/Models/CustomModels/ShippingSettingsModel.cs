using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    public partial record ShippingSettingsModel : BaseNopModel, ISettingsModel
    {
        [NopResourceDisplayName("Admin.Configuration.Settings.Shipping.AllowTimeSlotsInPickupInStore")]
        public bool AllowTimeSlotsInPickupInStore { get; set; }
        public bool AllowTimeSlotsInPickupInStore_OverrideForStore { get; set; }
        [NopResourceDisplayName("Admin.Configuration.Settings.Shipping.OrderLimitPerTimeSlot")]
        public bool OrderLimitPerTimeSlot { get; set; }
        public bool OrderLimitPerTimeSlot_OverrideForStore { get; set; }
    }
}
