using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using TomatoTimer.Entities;
using TomatoTimer.Forms;

namespace TomatoTimer
{
    public partial class Form1 : Form
    {
        private double countdownMinutes;
        private DateTime countdownFinished;
        private TomatoState currentState;
        private Bucket currentBucket;

        public List<Tomato> Tomatoes { get; set; }

        public List<Bucket> Buckets { get; set; }

        public Form1()
        {
            InitializeComponent();

            countdownMinutes = Convert.ToDouble(ConfigurationManager.AppSettings["CountdownMinutes"]);
            currentState = TomatoState.Stopped;

            RefreshUI();
        }

        private void RefreshUI()
        {
            cboBuckets.Items.Clear();
            //foreach (var bucket in Buckets)
            //{
            //    cboBuckets.Items.Add(bucket.Name);
            //}

            cmdStart.Enabled = currentState == TomatoState.Stopped;
            cmdStop.Enabled = currentState == TomatoState.Started;
            cboBuckets.Enabled = currentState == TomatoState.Started;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            StartTomato();
            RefreshUI();
        }

        private void StartTomato()
        {
            currentState = TomatoState.Started;
            countdownFinished = DateTime.Now.AddMinutes(countdownMinutes);
            currentBucket = new Bucket();

            timerUI.Start();
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            var timeRemaining = getTimeRemaining();
            lblTimer.Text = string.Format("{0} : {1}", timeRemaining.ToString("mm"), timeRemaining.ToString("ss"));

            if (timeRemaining.TotalSeconds < 1)
            {
                timerUI.Stop();
                currentState = TomatoState.Stopped;
                MessageBox.Show("Done!");
                RefreshUI();
            }
        }

        private TimeSpan getTimeRemaining()
        {
            return countdownFinished.Subtract(DateTime.Now);
        }

        private void cmdManageBuckets_Click(object sender, EventArgs e)
        {
            var form = new ManageBuckets();
            form.Show();
        }
    }

    public enum TomatoState
    {
        Started,
        Stopped
    }
}