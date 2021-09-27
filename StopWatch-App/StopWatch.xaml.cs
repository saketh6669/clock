using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StopWatch_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StopWatch : ContentPage
    {
        Stopwatch stopwatch;
        private object display;
        private object reset;
        private readonly object startnstop;

        public StopWatch()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            display.Text = "00:00:00";
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void StartnStop(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                startnstop.Text = "Stop";
                display.TextColor = Color.White;
                stopwatch.Start();
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    TimeSpan ts = stopwatch.Elapsed;

                    display.Text = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
                    return true;
                });
                reset.IsVisible = false;
            }
            else
            {
                startnstop.Text = "Start";
                stopwatch.Stop();
                display.TextColor = Color.Red;
                reset.IsVisible = true;
            }

        }
        private void Restart(object sender, EventArgs e)
        {
            stopwatch.Reset();
            display.TextColor = Color.Black;
            reset.IsVisible = false;
        }
    }
}