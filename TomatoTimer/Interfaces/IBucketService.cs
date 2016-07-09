using System;
using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface IBucketService
    {
        List<Bucket> GetAll();

        Bucket GetByName(string bucketName);

        Bucket Get(Guid Id);

        Bucket Create(Bucket newBucket);

        Bucket Save(Bucket bucket);
    }
}