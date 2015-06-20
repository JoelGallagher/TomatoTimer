using System;

namespace TomatoTimer.Entities
{
    public class Tomato
    {
        public Guid Id { get; set; }

        public string Bucket { get; set; }

        public DateTime Completed { get; set; }

        public int Length { get; set; }
    }
}