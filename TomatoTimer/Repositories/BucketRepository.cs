using System.Collections.Generic;
using TomatoTimer.Entities;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Repositories
{
    public class BucketRepository : IBucketRepository
    {
        private List<Bucket> _buckets;

        public BucketRepository()
        {
            _buckets = new List<Bucket>
            {
                new Bucket { Name = "Default" },
                new Bucket { Name = "Work" },
                new Bucket { Name = "Study" }
            };
        }

        public List<Bucket> GetAll()
        {
            return _buckets;
        }

        public void Add(Bucket bucket)
        {
            _buckets.Add(bucket);
        }

        public void Delete(Bucket bucket)
        {
            _buckets.Remove(bucket);
        }
    }
}