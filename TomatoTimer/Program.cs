using Ninject;
using System;
using System.Windows.Forms;
using TomatoTimer.Interfaces;
using TomatoTimer.Repositories;
using TomatoTimer.Services;

namespace TomatoTimer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            InitializeNinject();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void InitializeNinject()
        {
            var ninja = new StandardKernel();
            ninja.Bind<IBucketRepository>().To(typeof(BucketRepository));
            ninja.Bind<ITomatoRepository>().To<TomatoRepository>();
            ninja.Bind<ITomatoService>().To<TomatoService>();
        }
    }
}