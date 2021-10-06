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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nomadic
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                Label lbl = lblEmail;
                ThicknessAnimation myDoubleAnimation = new ThicknessAnimation();
                myDoubleAnimation.From = new Thickness(184, 20, 0, 0);
                myDoubleAnimation.To = new Thickness(184, -10, 0, 0);
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AutoReverse = false;
                myDoubleAnimation.EasingFunction = new CubicEase();
                lbl.BeginAnimation(Label.MarginProperty, myDoubleAnimation);
            }
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                Label lbl = lblEmail;
                ThicknessAnimation myDoubleAnimation = new ThicknessAnimation();
                myDoubleAnimation.From = new Thickness(184, -10, 0, 0);
                myDoubleAnimation.To = new Thickness(184, 20, 0, 0);
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AutoReverse = false;
                myDoubleAnimation.EasingFunction = new CubicEase();
                lbl.BeginAnimation(Label.MarginProperty, myDoubleAnimation);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show(); 
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.ToString().Length == 0)
            {
                Label lbl = lblPassword;
                ThicknessAnimation myDoubleAnimation = new ThicknessAnimation();
                myDoubleAnimation.From = new Thickness(184, 20, 0, 0);
                myDoubleAnimation.To = new Thickness(184, -10, 0, 0);
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AutoReverse = false;
                myDoubleAnimation.EasingFunction = new CubicEase();
                lbl.BeginAnimation(Label.MarginProperty, myDoubleAnimation);
            }
        }

        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password.ToString().Length == 0)
            {
                Label lbl = lblPassword;
                ThicknessAnimation myDoubleAnimation = new ThicknessAnimation();
                myDoubleAnimation.From = new Thickness(184, -10, 0, 0);
                myDoubleAnimation.To = new Thickness(184, 20, 0, 0);
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AutoReverse = false;
                myDoubleAnimation.EasingFunction = new CubicEase();
                lbl.BeginAnimation(Label.MarginProperty, myDoubleAnimation);
            }
        }

        private void txtFullName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtFullName.Text.Length == 0)
            {
                Label lbl = lblFullName;
                ThicknessAnimation myDoubleAnimation = new ThicknessAnimation();
                myDoubleAnimation.From = new Thickness(184, 20, 0, 0);
                myDoubleAnimation.To = new Thickness(184, -10, 0, 0);
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AutoReverse = false;
                myDoubleAnimation.EasingFunction = new CubicEase();
                lbl.BeginAnimation(Label.MarginProperty, myDoubleAnimation);
            }
        }

        private void txtFullName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtFullName.Text.Length == 0)
            {
                Label lbl = lblFullName;
                ThicknessAnimation myDoubleAnimation = new ThicknessAnimation();
                myDoubleAnimation.From = new Thickness(184, -10, 0, 0);
                myDoubleAnimation.To = new Thickness(184, 20, 0, 0);
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AutoReverse = false;
                myDoubleAnimation.EasingFunction = new CubicEase();
                lbl.BeginAnimation(Label.MarginProperty, myDoubleAnimation);
            }
        }
    }
}
