using System;
using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface ITomatoRepository
    {
        Tomato Get(Guid id);

        List<Tomato> GetAll();

        void Add(Tomato tomato);

        void Delete(Guid id);
    }
}