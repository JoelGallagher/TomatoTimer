using System.Collections.Generic;
using TomatoTimer.Entities;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Services
{
    public class BucketService : IBucketService
    {
        private IBucketRepository _bucketRepository;

        #region CTOR

        public BucketService()
        {
        }

        public BucketService(IBucketRepository bucketRepository)
        {
            _bucketRepository = bucketRepository;
        }

        #endregion CTOR

        public IEnumerable<Bucket> GetAll()
        {
            var buckets = _bucketRepository.GetAll();
            return buckets;
        }
    }
}