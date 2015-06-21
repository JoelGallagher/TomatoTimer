using System;
using System.Collections.Generic;
using System.Linq;
using TomatoTimer.Entities;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Repositories
{
    public class TomatoRepository : ITomatoRepository
    {
        private List<Tomato> _tomatoes;

        public TomatoRepository()
        {
            _tomatoes = new List<Tomato>();
        }

        public override string ToString()
        {
            return "Tomato Repo CONRETE";
        }

        public Tomato Get(Guid id)
        {
            return new Tomato() { Bucket = "di repo bucket!" };
        }

        public List<Tomato> GetAll()
        {
            return _tomatoes;
        }

        public void Add(Tomato tomato)
        {
            _tomatoes.Add(tomato);
        }

        public void Delete(Guid id)
        {
            _tomatoes.Remove(_tomatoes.SingleOrDefault(t => t.Id == id));
        }
    }
}