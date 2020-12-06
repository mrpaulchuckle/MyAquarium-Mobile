using MyAquarium.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAquarium
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TankDetailPage), typeof(TankDetailPage));
            Routing.RegisterRoute(nameof(NewTankPage), typeof(NewTankPage));
        }
    }
}