namespace Nop.Core.Domain.Orders
{
    public partial class Order
    {
        public virtual int? StorePickupPointId { get; set; }
        public virtual int? StorePickupTimeSlotId { get; set; }
    }
}
