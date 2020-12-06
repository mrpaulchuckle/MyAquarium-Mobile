using MyAquarium.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAquarium.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TanksPage : ContentPage
    {
        TanksViewModel _ViewModel;

        public TanksPage()
        {
            InitializeComponent();
            BindingContext = _ViewModel = new TanksViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ViewModel.OnAppearing();
        }
    }
}