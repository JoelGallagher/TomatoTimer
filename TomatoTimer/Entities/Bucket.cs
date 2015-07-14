using System;

namespace TomatoTimer.Entities
{
    public class Bucket
    {
        public Bucket()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}