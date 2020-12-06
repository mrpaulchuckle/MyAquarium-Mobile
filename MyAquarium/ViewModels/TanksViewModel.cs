using MyAquarium.Models;
using MyAquarium.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAquarium.ViewModels
{
    public class TanksViewModel : BaseViewModel
    {
        private TankModel _SelectedTank;

        public ObservableCollection<TankModel> Tanks { get; }
        public Command LoadTanksCommand { get; }
        public Command AddTankCommand { get; }
        public Command<TankModel> TankTapped { get; }

        public TanksViewModel()
        {
            Title = "Tanks";
            Tanks = new ObservableCollection<TankModel>();
            LoadTanksCommand = new Command(async () => await ExecuteLoadTanksCommand());

            TankTapped = new Command<TankModel>(OnTankSelected);

            AddTankCommand = new Command(OnAddTank);
        }

        async Task ExecuteLoadTanksCommand()
        {
            IsBusy = true;

            try
            {
                Tanks.Clear();
                IEnumerable<TankModel> myTanks = await DataStore.GetTanksAsync(true);
                foreach (TankModel myTank in myTanks)
                {
                    Tanks.Add(myTank);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedTank = null;
        }

        public TankModel SelectedTank
        {
            get => _SelectedTank;
            set
            {
                SetProperty(ref _SelectedTank, value);
                OnTankSelected(value);
            }
        }

        private async void OnAddTank(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewTankPage));
        }

        async void OnTankSelected(TankModel tank)
        {
            if (tank == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(TankDetailPage)}?{nameof(TankViewModel.ID)}={tank.ID}");
        }
    }
}