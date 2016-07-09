using System;
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

        public List<Bucket> GetAll()
        {
            var buckets = _bucketRepository.GetAll();
            return buckets;
        }

        public Bucket GetByName(string bucketName)
        {
            var buckets = GetAll();
            var bucket = buckets.FirstOrDefault(b => b.Name == bucketName);

            return bucket ?? new Bucket();
        }

        public Bucket Get(Guid Id)
        {
            var buckets = GetAll();
            var bucket = buckets.FirstOrDefault(b => b.Id == Id);

            return bucket ?? new Bucket();
        }

        public Bucket Create(Bucket newBucket)
        {
            newBucket.Id = Guid.NewGuid();
            newBucket = _bucketRepository.Save(newBucket);
            return newBucket;
        }

        public Bucket Save(Bucket bucket)
        {
            var savedBucket = _bucketRepository.Save(bucket);
            return savedBucket;
        }
    }
}