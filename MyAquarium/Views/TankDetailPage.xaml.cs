using MyAquarium.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAquarium.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TankDetailPage : ContentPage
    {
        public TankDetailPage()
        {
            InitializeComponent();
            BindingContext = new TankViewModel();
        }
    }
}