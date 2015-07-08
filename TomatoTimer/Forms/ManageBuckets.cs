using System;
using System.Windows.Forms;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Forms
{
    public partial class ManageBuckets : Form
    {
        private ITomatoService _tomatoService;
        private IBucketService _bucketService;
        private formState currentFormState;

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
            currentFormState = formState.clean;
            LoadBuckets();
            LoadFormState();
        }

        public ManageBuckets()
        {
            InitializeComponent();
            currentFormState = formState.clean;
            LoadBuckets();
            LoadFormState();
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
            var callingbutton = (Button)sender;
            currentFormState = formState.editingBucket;
            LoadBucketForEdit(callingbutton.Text);
        }

        private void LoadBucketForEdit(string bucketname)
        {
            var bucket = _bucketService.Get(bucketname);
            txtBucketName.Text = bucket.Name;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewBucket_Click(object sender, EventArgs e)
        {
            currentFormState = formState.newBucket;
            LoadFormState();
        }

        private void LoadFormState()
        {
            switch (currentFormState)
            {
                case formState.clean:
                    cmdSave.Enabled = false;
                    cmdDelete.Enabled = false;
                    break;

                case formState.editingBucket:
                    cmdSave.Enabled = true;
                    cmdDelete.Enabled = true;
                    break;

                case formState.newBucket:
                    break;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
        }
    }
}