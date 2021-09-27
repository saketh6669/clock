using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StopWatch_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DigitalClock : ContentPage
    {
        Stopwatch stopwatch;
        private object time;

        public DigitalClock()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            Clock();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Clock()
        {
            stopwatch.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                time.Text = DateTime.Now.ToString("hh:mm:ss tt");
                return true;
            });
        }
    }
}