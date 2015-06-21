using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TomatoTimer.Entities;
using TomatoTimer.Interfaces;
using TomatoTimer.Repositories;

namespace TomatoTimerTests
{
    [TestClass]
    public class TomatoRepositoryTests
    {
        private ITomatoRepository _tomatoRepository;

        [TestInitialize]
        public void Init()
        {
            _tomatoRepository = new TomatoRepository();
        }

        [TestMethod]
        public void GivenEmptyRepoWhenAdd1ThenGet1InRepo()
        {
            var initialTomatoes = _tomatoRepository.GetAll();
            Assert.AreEqual(0, initialTomatoes.Count);

            var newTomato = new Tomato();

            _tomatoRepository.Add(newTomato);

            var fetchedTomatoes = _tomatoRepository.GetAll();
            Assert.AreEqual(1, fetchedTomatoes.Count);
        }

        [TestMethod]
        public void GivenRepoWith1Tomato_WhenDelete_ThenGetEmptyRepo()
        {
            _tomatoRepository.Add(new Tomato());
            var initialTomatoes = _tomatoRepository.GetAll();
            Assert.AreEqual(1, initialTomatoes.Count);

            _tomatoRepository.Delete(initialTomatoes.First().Id);
            var fetchedTomatoes = _tomatoRepository.GetAll();
            Assert.AreEqual(0, fetchedTomatoes.Count);
        }
    }
}