﻿using System.Collections.Generic;
using System.Threading.Tasks;

using ProductPriceTracking.Bll.Interfaces;
using ProductPriceTracking.Dal.Interfaces;
using ProductPriceTracking.Entities.Concrete;

namespace ProductPriceTracking.Bll.Concrete
{
    public class TrackingRecordManager : ITrackingRecordService
    {
        private readonly ITrackingRecordDal trackingRecordDal;

        public TrackingRecordManager(ITrackingRecordDal trackingRecordDal)
        {
            this.trackingRecordDal = trackingRecordDal;
        }
        public async Task<Product> GetLoadedProductById(int productId)
        {
            return await trackingRecordDal.GetLoadedProductById(productId);
        }

    }
}
