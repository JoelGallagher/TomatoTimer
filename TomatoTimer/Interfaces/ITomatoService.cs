using System;
using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface ITomatoService
    {
        Tomato Get(Guid id);

        IEnumerable<Tomato> GetAll();
    }
}