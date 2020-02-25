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

namespace actoong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int PlayerCounter { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hadar_Click(object sender, RoutedEventArgs e)
        {
            Hadar.Opacity = 1;
            HadarLeftBox.Visibility = Visibility.Visible;
            string HadarLeft = HadarLeftBox.Text;
            HadarRightBox.Visibility = Visibility.Visible;
            string HadarRight = HadarRightBox.Text;
            PlayerCounter += 1;
            if (PlayerCounter >= 2)
                Start.Opacity = 1;
        }

        private void Yedidya_Click(object sender, RoutedEventArgs e)
        {
            Yedidya.Opacity = 1;
            string YedidyaLeft = YedidyaLeftBox.Text;
            string YedidyaRight = YedidyaRightBox.Text;
            PlayerCounter += 1;
            if (PlayerCounter >= 2)
                Start.Opacity = 1;
        }

        private void Dodik_Click(object sender, RoutedEventArgs e)
        {
            Dodik.Opacity = 1;
            string DodikLeft = DodikLeftBox.Text;
            string DodikRight = DodikRightBox.Text;
            PlayerCounter += 1;
            if (PlayerCounter >= 2)
                Start.Opacity = 1;
        }

        private void Yoel_Click(object sender, RoutedEventArgs e)
        {
            Yoel.Opacity = 1;
            string YoelLeft = YoelLeftBox.Text;
            string YoelRight = YoelRightBox.Text;
            PlayerCounter += 1;
            if (PlayerCounter >= 2)
                Start.Opacity = 1;
        }

        private void Harel_Click(object sender, RoutedEventArgs e)
        {
            Harel.Opacity = 1;
            string HarelLeft = HarelLeftBox.Text;
            string HarelRight = HarelRightBox.Text;
            PlayerCounter += 1;
            if (PlayerCounter >= 2)
                Start.Opacity = 1;
        }

        private void Koby_Click(object sender, RoutedEventArgs e)
        {
            Koby.Opacity = 1;
            string KobyLeft = KobyLeftBox.Text;
            string kobyRight = KobyRightBox.Text;
            PlayerCounter += 1;
            if (PlayerCounter >= 2)
                Start.Opacity = 1;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            CheckValidation();
        }

        private void CheckValidation()
        {
            if(Hadar.Opacity == 1)
            {
                if (HadarLeftBox.Text.Length > 1)
                    MessageBox.Show("Hadar's data not correct");
            }
        }
    }
}
