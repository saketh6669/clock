using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using Xamarin.Forms.Xaml;

namespace StopWatch_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class Clock : ContentPage
    {
        // Stopwatch stopWatch;
        TimeSpan starttime;
        int sec = 0;
        private object startnstop;
        private object fixing_time;
        private object running_time;
        private object minutes;
        private object hours;
        private object display;
        private object reset;

        public Clock()
        {
            InitializeComponent();
            //stopWatch = new Stopwatch();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void StartnStop(object sender, EventArgs e)
        {
            if (startnstop.Text == "Start")
            {
                fixing_time.IsVisible = false;
                running_time.IsVisible = true;
                sec += Convert.ToInt32(hours.Text) * 3600;
                sec += Convert.ToInt32(minutes.Text) * 60;
                sec += Convert.ToInt32(seconds.Text);
                starttime = TimeSpan.FromSeconds(sec);
                //stopWatch.Start();
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    starttime = starttime - TimeSpan.FromSeconds(1);
                    //  TimeSpan ts = starttime.Elapsed;
                    display.Text = string.Format("{0:00}:{1:00}:{2:00}", starttime.Hours, starttime.Minutes, starttime.Seconds);
                    return true;
                });
                startnstop.Text = "Stop";

            }
            else
            {

                reset.IsVisible = true;
                startnstop.Text = "Start";

            }
        }

        private void Restart(object sender, EventArgs e)
        {
            //timer.Stop();
        }
    }
}