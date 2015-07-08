using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface IBucketService
    {
        IEnumerable<Bucket> GetAll();

        Bucket Get(string bucketName);
    }
}