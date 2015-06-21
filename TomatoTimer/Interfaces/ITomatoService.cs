using System;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface ITomatoService
    {
        Tomato Get(Guid id);
    }
}