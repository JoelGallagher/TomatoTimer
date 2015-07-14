using System;
using System.Windows.Forms;
using TomatoTimer.Entities;
using TomatoTimer.Interfaces;

namespace TomatoTimer.Forms
{
    public partial class ManageBuckets : Form
    {
        private ITomatoService _tomatoService;
        private IBucketService _bucketService;
        private formState currentFormState;
        private Guid currentEditedBucketId;

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
            pnlBuckets.Controls.Clear();

            var buckets = _bucketService.GetAll();
            foreach (var bucket in buckets)
            {
                var button = new Button
                {
                    Tag = bucket,
                    Text = bucket.Name,
                    Name = "btnBucket" + bucket.Id,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    AutoSize = true
                };

                button.Click += btnBucketClick;
                pnlBuckets.Controls.Add(button);
            }
        }

        private void btnBucketClick(object sender, EventArgs e)
        {
            var callingbutton = (Button)sender;
            var targetBucket = (Bucket)callingbutton.Tag;
            currentFormState = formState.editingBucket;
            LoadBucketForEdit(targetBucket);
            LoadFormState();
        }

        private void LoadBucketForEdit(Bucket bucket)
        {
            currentEditedBucketId = bucket.Id;
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
            lblFormState.Text = currentFormState.ToString();

            switch (currentFormState)
            {
                case formState.clean:
                    cmdSave.Enabled = false;
                    cmdDelete.Enabled = false;
                    currentEditedBucketId = Guid.Empty;
                    break;

                case formState.editingBucket:
                    cmdSave.Enabled = true;
                    cmdDelete.Enabled = true;
                    break;

                case formState.newBucket:
                    cmdSave.Enabled = true;
                    cmdDelete.Enabled = false;
                    txtBucketName.Clear();
                    txtBucketName.Focus();
                    currentEditedBucketId = Guid.Empty;
                    break;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (currentFormState == formState.newBucket)
            {
                // Create New
                var newBucket = new Bucket()
                {
                    Name = txtBucketName.Text
                };
                newBucket = _bucketService.Create(newBucket);
                currentEditedBucketId = newBucket.Id;
                currentFormState = formState.editingBucket;
                LoadFormState();
            }
            else
            {
                // Save Existing
                var savedBucket = new Bucket
                {
                    Id = currentEditedBucketId,
                    Name = txtBucketName.Text
                };
                savedBucket = _bucketService.Save(savedBucket);
            }

            LoadBuckets();
        }
    }
}