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

namespace Spinning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public int StarCount
        {
            get { return (int)GetValue(StarCountProperty); }
            set { SetValue(StarCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StarCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StarCountProperty =
            DependencyProperty.Register("StarCount", typeof(int), typeof(MainWindow));


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void star1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StarCount = 1;
        }

        private void star2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StarCount = 2;
        }

        private void star3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StarCount = 3;
        }

        private void star4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StarCount = 4;
        }

        private void star5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StarCount = 5;
        }
    }
}
