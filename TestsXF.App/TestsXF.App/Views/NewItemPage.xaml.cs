using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestsXF.App.Models;
using TestsXF.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestsXF.App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}