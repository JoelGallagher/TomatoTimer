using System;
using System.Windows.Forms;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Forms
{
    public partial class ManageBuckets : Form
    {
        private ITomatoService _tomatoService;
        private IBucketService _bucketService;

        private enum formState
        {
            clean,
            editingBucket,
            newBucket
        }

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
            foreach (var bucket in buckets)
            {
                var button = new Button();
                button.Text = bucket.Name;
                button.Name = "btn" + bucket.Name;
                button.Click += btnBucketClick;
                pnlBuckets.Controls.Add(button);
            }
        }

        private void btnBucketClick(object sender, EventArgs e)
        {
            var x = sender;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnNewBucket_Click(object sender, EventArgs e)
        {
        }
    }
}