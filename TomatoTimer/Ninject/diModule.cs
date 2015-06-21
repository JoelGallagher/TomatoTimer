using Ninject.Modules;
using TomatoTimer.Interfaces;
using TomatoTimer.Repositories;
using TomatoTimer.Services;

namespace TomatoTimer.Ninject
{
    internal class diModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBucketRepository>().To<BucketRepository>();
            Bind<ITomatoRepository>().To<TomatoRepository>();
            Bind<ITomatoService>().To<TomatoService>();
        }
    }
}