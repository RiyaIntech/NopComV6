using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Pickup.PickupInStore.Models;
using Nop.Plugin.Pickup.PickupInStore.Services;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Pickup.PickupInStore.Components
{
    [ViewComponent(Name = "PickupInStoreTimeSlot")]
    public class PickupInStoreTimeSlotComponent : NopViewComponent
    {
        private readonly IStorePickupTimeSlotService _storePickupTimeSlotService;
        public PickupInStoreTimeSlotComponent(IStorePickupTimeSlotService storePickupTimeSlotService)
        {
            _storePickupTimeSlotService = storePickupTimeSlotService;
        }
        public IViewComponentResult Invoke(int storePickupPointId)
        {
            //var obj = JObject.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(additionalData, new Newtonsoft.Json.JsonSerializerSettings()));

            //int storePickupPointId = Convert.ToInt32(obj["storePickupPointId"]);

            var model = new TimeSlotListModel();


            var timeSlotsList = _storePickupTimeSlotService.GetAllStorePickupTimeSlotAsync(storePickupPointId).Result;
            foreach (var item in timeSlotsList)
            {
                model.Add(item);
            }
            return View("~/Plugins/Pickup.PickupInStore/Views/TimeSlotInfo.cshtml", model);

        }
    }
}
