using Nop.Core.Configuration;

namespace Nop.Core.Domain.Shipping
{
    public partial class ShippingSettings : ISettings
    {
        public bool AllowTimeSlotsInPickupInStore { get; set; }
        public bool OrderLimitPerTimeSlot { get; set; }
    }
}
