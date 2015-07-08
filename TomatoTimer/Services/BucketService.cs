using System.Collections.Generic;
using System.Linq;
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

        public Bucket Get(string bucketName)
        {
            var buckets = GetAll();
            var bucket = buckets.FirstOrDefault(b => b.Name == bucketName);

            return bucket ?? new Bucket();
        }
    }
}