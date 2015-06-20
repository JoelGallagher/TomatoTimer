using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface IBucketRepository
    {
        List<Bucket> GetAll();

        void Add(Bucket bucket);

        void Delete(Bucket bucket);
    }
}