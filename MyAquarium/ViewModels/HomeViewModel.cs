using MyAquarium.Models;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyAquarium.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private TankModel _FavouriteTank;

        public Command LoadFavouriteTankCommand { get; }
        public Command<TankModel> TankTapped { get; }
        public HomeViewModel()
        {
            Title = "Home";
        }
    }
}
