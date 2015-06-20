using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Repositories
{
    public interface ITomatoRepository
    {
        List<Tomato> GetAll();

        void Add(Tomato tomato);
    }
}