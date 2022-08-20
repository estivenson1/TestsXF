using System;
using System.Collections.Generic;
using TestsXF.App.ViewModels;
using TestsXF.App.Views;
using Xamarin.Forms;

namespace TestsXF.App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        { 
            try
            {
                await Shell.Current.GoToAsync("//LoginPage");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            
        }
    }
}
