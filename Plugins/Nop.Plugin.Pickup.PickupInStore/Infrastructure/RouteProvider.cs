using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Pickup.PickupInStore.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public int Priority => 1;

        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute("getPickupTimeSlotHtml", "getPickupTimeSlotHtml",
               new { controller = "PickupInStore", action = "getPickupTimeSlotHtml" });

        }
    }
}
