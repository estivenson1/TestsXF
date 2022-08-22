using System;
using System.Collections.Generic;
using System.Text;
using TestsXF.App.Models;
using TestsXF.App.Views;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestsXF.App.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string userName;
        private string password;
        private UserModel user;
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            User=new UserModel();
            LoginCommand = new Command(OnLoginClicked, ValidateLogin);
            this.PropertyChanged += (_, __) => LoginCommand.ChangeCanExecute();
        }

        private bool ValidateLogin(object obj)
        {
            return !String.IsNullOrWhiteSpace(UserName)
                && !String.IsNullOrWhiteSpace(Password);
        }

        public string UserName{ get => userName; set => SetProperty(ref userName, value); }
        public string Password{ get => password; set => SetProperty(ref password, value); }
        public UserModel User { get => user; set => SetProperty(ref user, value); }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        public void OnLogin(string userName,string password)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }else if (password == null) 
            { 
                throw new ArgumentNullException(nameof(password)); 
            }
        }
    }
}
