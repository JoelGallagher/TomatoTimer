using Ninject;
using System;
using System.Windows.Forms;

namespace TomatoTimer
{
    internal static class Program
    {
        public static StandardKernel ninja;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}