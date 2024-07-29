using Microsoft.UI.Xaml;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Clock
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            this.InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += DispatcherTimerTick;
            timer.Start();
        }

        private void DispatcherTimerTick(object sender, object e)
        {
            digitalClockOutput.Text = $"{DateTime.Now.ToString("HH:mm:ss")}"; 
        }
    }
}
