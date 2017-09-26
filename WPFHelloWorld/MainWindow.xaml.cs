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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFHelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clickCount;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mijnKnop1_Click(object sender, RoutedEventArgs e)
        {
            mijnLabel.Content = "De wereldbol is een ruimteschip.";
            mijnStatusLabel.Background = Brushes.Red;
            clickCount = clickCount + 1;
            mijnKnop1.Content = "Klik hier! [" + clickCount + "]";
        }
    }
}
