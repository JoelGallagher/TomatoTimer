using Ninject;
using System;
using System.Windows.Forms;
using TomatoTimer.Interfaces;
using TomatoTimer.Ninject;

namespace TomatoTimer.Forms
{
    public partial class ManageBuckets : Form
    {
        private ITomatoService _tomatoService;

        public ManageBuckets()
        {
            InitializeComponent();
            var kernel = new StandardKernel(new diModule());
            _tomatoService = kernel.Get<ITomatoService>();
        }

        private void cmdHitRepo_Click(object sender, System.EventArgs e)
        {
            var x = _tomatoService.Get(Guid.NewGuid());
        }
    }
}