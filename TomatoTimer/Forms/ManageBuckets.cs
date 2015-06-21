using System;
using System.Windows.Forms;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Forms
{
    public partial class ManageBuckets : Form
    {
        private ITomatoService _tomatoService;

        #region CTOR

        public ManageBuckets(ITomatoService tomatoService)
        {
            _tomatoService = tomatoService;
            InitializeComponent();
        }

        public ManageBuckets()
        {
            InitializeComponent();
        }

        #endregion CTOR

        private void cmdHitRepo_Click(object sender, System.EventArgs e)
        {
            var x = _tomatoService.Get(Guid.NewGuid());
        }
    }
}