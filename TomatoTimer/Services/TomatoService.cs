using System;
using System.Collections.Generic;
using TomatoTimer.Entities;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Services
{
    internal class TomatoService : ITomatoService
    {
        private ITomatoRepository _tomatoRepository { get; set; }

        public TomatoService()
        {
        }

        public TomatoService(ITomatoRepository tomatoRepository)
        {
            _tomatoRepository = tomatoRepository;
        }

        public Tomato Get(Guid id)
        {
            var tomato = _tomatoRepository.Get(id);

            return tomato;
        }

        public IEnumerable<Tomato> GetAll()
        {
            var tomatoes = _tomatoRepository.GetAll();

            return tomatoes;
        }
    }
}