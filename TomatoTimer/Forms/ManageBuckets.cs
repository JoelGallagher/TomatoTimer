using System;
using System.Windows.Forms;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Forms
{
    public partial class ManageBuckets : Form
    {
        private ITomatoService _tomatoService;
        private IBucketService _bucketService;

        #region CTOR

        public ManageBuckets(ITomatoService tomatoService, IBucketService bucketService)
        {
            _tomatoService = tomatoService;
            _bucketService = bucketService;
            InitializeComponent();
            LoadBuckets();
        }

        public ManageBuckets()
        {
            InitializeComponent();
            LoadBuckets();
        }

        #endregion CTOR

        private void LoadBuckets()
        {
            var buckets = _bucketService.GetAll();

            gridBuckets.DataSource = buckets;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}