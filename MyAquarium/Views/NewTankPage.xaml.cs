using MyAquarium.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAquarium.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTankPage : ContentPage
    {
        public NewTankPage()
        {
            InitializeComponent();
            BindingContext = new NewTankViewModel();
        }
    }
}