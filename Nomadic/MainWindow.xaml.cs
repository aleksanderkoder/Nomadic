using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nomadic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserInterface ui = new UserInterface("test");
            ui.Show();
        }
        private async void btnSignInClick(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password.ToString();
            Trace.WriteLine("Test user: test@test.com, Testpass1*");
            if (!Reg.ValidateEmail(email))
            {
                txtError.Text = "Please provide a valid email address!";
                return; 
            } else if(!Reg.ValidatePassword(password))
            {
                txtError.Text = "Please provide a valid password!";
                return;
            }
                
            APIResponse result = await APIClient.SignInUser(email, password);

            if (result.Status == "true")  // Successful login
            {
                // Show app page
                // Get files from server
                Trace.WriteLine("Riktig");
                txtError.Text = "";
                this.Hide(); 
                UserInterface ui = new UserInterface(email);
                ui.Show(); 
            } else if(result.Message == "Error deserializing API response!") // Error reading API response
            {
                txtError.Text = result.Message; 
            }
            else  // Unsuccessful login
            {
                Trace.WriteLine("Feil");
                txtError.Text = "Wrong username or password!";
            }
        }

        // Handles form animations based on focus
        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
           if(txtEmail.Text.Length == 0)
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

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
