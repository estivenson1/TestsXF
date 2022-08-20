using System;
using System.Collections.Generic;
using System.Text;
using TestsXF.App.Views;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestsXF.App.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string userName;
        private string password;
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked, ValidateLogin);
            this.PropertyChanged += (_, __) => LoginCommand.ChangeCanExecute();
        }

        private bool ValidateLogin(object obj)
        {
            return !String.IsNullOrWhiteSpace(userName)
                && !String.IsNullOrWhiteSpace(password);
        }

        public string UserName{ get => userName; set => SetProperty(ref userName, value); }
        public string Password{ get => password; set => SetProperty(ref password, value); }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
