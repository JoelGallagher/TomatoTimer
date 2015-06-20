using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Interfaces
{
    public interface ITomatoRepository
    {
        List<Tomato> GetAll();

        void Add(Tomato tomato);
    }
}