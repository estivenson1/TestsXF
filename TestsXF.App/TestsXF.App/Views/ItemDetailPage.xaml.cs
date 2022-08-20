using System.ComponentModel;
using TestsXF.App.ViewModels;
using Xamarin.Forms;

namespace TestsXF.App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}