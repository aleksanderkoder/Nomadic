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

namespace Nomadic
{
    /// <summary>
    /// Interaction logic for UserInterface.xaml
    /// </summary>
    public partial class UserInterface : Window
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNewFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowFiles_Click(object sender, RoutedEventArgs e)
        {
            listFiles.Visibility = Visibility.Visible; 
        }

        private void btnRecent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
