using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Speko.Overlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartMeeting_Click(object sender, RoutedEventArgs e)
        {
            // Create and show the overlay window
            MeetingMode meetingMode = new MeetingMode();
            meetingMode.Show();

            // Hide (not close) the main dashboard
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Position the overlay at the top center of the screen
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double windowWidth = this.Width;
            this.Left = (screenWidth - windowWidth) / 2; // center horizontally
            this.Top = 20; // 20 pixels from top edge
        }
    }
}
