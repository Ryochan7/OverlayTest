using System;
using System.Collections.Generic;
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
using NonFormTimer = System.Timers.Timer;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NonFormTimer testTimer = new NonFormTimer();

        public MainWindow()
        {
            InitializeComponent();

            //this.ShowActivated = true;
            //this.Topmost = true;

            // When bringing up an existing window. Make sure to perform a
            // Hide() followed by a Show(). Make sure window is not set to
            // activate when shown. Topmost is already set from XAML file
            this.Show();
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
    }
}
