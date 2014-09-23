using System.Collections.Generic;
using TomatoTimer.Entities;

namespace TomatoTimer.Repositories
{
    public class TomatoRepository
    {
        private List<Tomato> _tomatoes;

        public TomatoRepository()
        {
            _tomatoes = new List<Tomato>();
        }

        public List<Tomato> GetAll()
        {
            return _tomatoes;
        }

        public void Add(Tomato tomato)
        {
            _tomatoes.Add(tomato);
        }
    }
}
