using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.ViewModels;
using NonFormTimer = System.Timers.Timer;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NonFormTimer testTimer = new NonFormTimer();
        private MainWinViewModel mainWinVM = new MainWinViewModel();
        private Stopwatch elapsedWatch = new Stopwatch();

        private const long WAIT_TIME = 5000;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = mainWinVM;

            testTimer.Elapsed += TestTimer_Elapsed;
            testTimer.Interval = 500;

            //this.ShowActivated = false;
            //this.Topmost = true;

            // When bringing up an existing window. Make sure to perform a
            // Hide() followed by a Show(). Make sure window is not set to
            // activate when shown. Topmost is already set from XAML file
            this.Show();
            //this.Activate();
            //this.Focusable = true;
            //this.Focus();
            //this.Topmost = true;

            elapsedWatch.Start();
            testTimer.Start();
        }

        private void TestTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            testTimer.Stop();

            if (elapsedWatch.ElapsedMilliseconds <= WAIT_TIME)
            {
                mainWinVM.RefreshTime();
                testTimer.Start();
            }
            else
            {
                elapsedWatch.Stop();
                // Need to invoke in UI thread
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    Close();
                }));
            }
        }


        /// <summary>
        /// Test method that does nothing now
        /// </summary>
        public void Baconator()
        {
            //this.ShowActivated = false;
            //this.Topmost = false;



            //this.Topmost = false;
            //this.Activate();

            //this.Hide();
            
            //await Task.Delay(100);
            //this.Topmost = true;
            //this.Activate();
            //this.Show();
            //this.Topmost = false;
            //this.Show();
            //this.WindowState = WindowState.Normal;
            //this.Activate();
            //this.Visibility = Visibility.Visible;
            //this.Focusable = false;
            //this.Focus();
            //this.Activate();
            //this.WindowStyle = WindowStyle.ToolWindow;
            //this.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Invoke app shutdown when button is clicked
            Application.Current.Shutdown(0);
        }

        ~MainWindow()
        {
            testTimer.Stop();
            testTimer.Dispose();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown(0);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
