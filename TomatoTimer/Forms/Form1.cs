using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using TomatoTimer.Entities;
using TomatoTimer.Forms;
using TomatoTimer.Interfaces;

namespace TomatoTimer
{
    public partial class Form1 : Form
    {
        private double countdownMinutes;
        private DateTime countdownFinished;
        private formState currentFormState;
        private ITomatoService _tomatoService;
        private IBucketService _bucketService;
        private Bucket currentBucket;

        public List<Tomato> Tomatoes { get; set; }

        private List<Bucket> _buckets;

        public Form1()
        {
            Setup();
        }

        public Form1(ITomatoService tomatoService, IBucketService bucketService)
        {
            _tomatoService = tomatoService;
            _bucketService = bucketService;
            Setup();
        }

        private void Setup()
        {
            InitializeComponent();

            countdownMinutes = Convert.ToDouble(ConfigurationManager.AppSettings["CountdownMinutes"]);
            currentFormState = formState.Clean;
            LoadBuckets();

            LoadFormState();
        }

        private void LoadBuckets()
        {
            _buckets = new List<Bucket>(_bucketService.GetAll().OrderBy(b => b.Name));
            foreach (var bucket in _buckets)
            {
                lstBuckets.Items.Add(bucket);
            }
        }

        private void LoadFormState()
        {
            lblFormState.Text = currentFormState.ToString();

            switch (currentFormState)
            {
                case formState.CountingDown:
                    cmdPause.Enabled = true;
                    cmdStart.Enabled = false;
                    cmdStop.Enabled = true;
                    lstBuckets.Enabled = false;
                    break;

                case formState.Paused:
                    cmdPause.Enabled = false;
                    cmdStart.Enabled = true;
                    cmdStop.Enabled = true;
                    lstBuckets.Enabled = false;
                    break;

                case formState.Clean:
                    cmdPause.Enabled = false;
                    cmdStart.Enabled = true;
                    cmdStop.Enabled = false;
                    lstBuckets.Enabled = true;
                    break;
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            StartTomato();
            LoadFormState();
        }

        private void StartTomato()
        {
            currentFormState = formState.CountingDown;
            countdownFinished = DateTime.Now.AddMinutes(countdownMinutes);
            currentBucket = new Bucket();

            timerUI.Start();
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            if (currentFormState != formState.CountingDown) return;

            var timeRemaining = getTimeRemaining();
            lblTimer.Text = string.Format("{0} : {1}", timeRemaining.ToString("mm"), timeRemaining.ToString("ss"));

            if (timeRemaining.TotalSeconds < 1)
            {
                timerUI.Stop();
                TomatoCompleted();
            }
        }

        private void TomatoCompleted()
        {
            currentFormState = formState.Clean;

            // todo process tomato => bucket
            MessageBox.Show("Done!");
            LoadFormState();
        }

        private TimeSpan getTimeRemaining()
        {
            return countdownFinished.Subtract(DateTime.Now);
        }

        private void cmdManageBuckets_Click(object sender, EventArgs e)
        {
            var form = new ManageBuckets(_tomatoService, _bucketService);
            form.Show();
        }

        private void cmdPause_Click(object sender, EventArgs e)
        {
            currentFormState = formState.Paused;
            LoadFormState();
        }
    }

    internal enum formState
    {
        CountingDown,
        Paused,
        Clean
    }
}