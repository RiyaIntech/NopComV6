using Nop.Core;
using Nop.Plugin.Pickup.PickupInStore.Models;
using Nop.Plugin.Pickup.PickupInStore.Services;
using Nop.Services.Localization;
using Nop.Services.Shipping.Pickup;
using Nop.Services.Stores;
using Nop.Web.Framework.Models.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Pickup.PickupInStore.Factories
{
    public class StorePickupTimeSlotModelFactory : IStorePickupTimeSlotModelFactory
    {
        #region Fields

        private readonly IStorePickupTimeSlotService _storePickupTimeSlotService;
        private readonly ILocalizationService _localizationService;
        private readonly IStoreService _storeService;
        private readonly IPickupPluginManager _pickupPluginManager;
        private readonly IWebHelper _webHelper;
        #endregion

        #region Ctor

        public StorePickupTimeSlotModelFactory(IStorePickupTimeSlotService storePickupTimeSlotService,
            ILocalizationService localizationService, IStoreService storeService,
            IPickupPluginManager pickupPluginManager,
            IWebHelper webHelper)
        {
            _storePickupTimeSlotService = storePickupTimeSlotService;
            _localizationService = localizationService;
            _storeService = storeService;
            _pickupPluginManager = pickupPluginManager;
            _webHelper = webHelper;
        }

        #endregion
        public Task<StorePickupTimeSlotSearchModel> PrepareStorePickuptTimeSlotModelAsync(StorePickupTimeSlotSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //prepare page parameters
            searchModel.SetGridPageSize();

            return Task.FromResult(searchModel);
        }

        public async Task<StorePickupTimeSlotListModel> PrepareStorePickupTimeSlotListModelAsync(int storePickUpPointId, StorePickupTimeSlotSearchModel searchModel)
        {
            var pickupPoints = await _storePickupTimeSlotService.GetStorePickupTimeSlotAsync(storePickUpPointId, pageIndex: searchModel.Page - 1, pageSize: searchModel.PageSize);
            //get pickup point providers
            var pickupPointProviders = (await _pickupPluginManager.LoadAllPluginsAsync()).ToPagedList(searchModel);

            var model = await new StorePickupTimeSlotListModel().PrepareToGridAsync(searchModel, pickupPoints, () =>
            {
                return pickupPoints.SelectAwait(async point =>
                {

                    return new StorePickupTimeSlotModel
                    {
                        Id = point.Id,
                        StorePickupPointId = point.StorePickupPointId,
                        TimeSlot = point.TimeSlot,
                        LimitOrderPerTimeSlot = point.LimitOrderPerTimeSlot.HasValue ? point.LimitOrderPerTimeSlot.Value : 0,
                        Active = point.Active,
                    };
                });
            });

            return model;
        }
    }
}
