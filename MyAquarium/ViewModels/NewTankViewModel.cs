using MyAquarium.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyAquarium.ViewModels
{
    public class NewTankViewModel : BaseViewModel
    {
        private string _Name;
        private string _Description;

        public NewTankViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(_Name)
                && !String.IsNullOrWhiteSpace(Description);
        }

        public string Text
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        public string Description
        {
            get => _Description;
            set => SetProperty(ref _Description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            TankModel myNewTank = new TankModel()
            {
                Name = Text,
                Description = Description
            };

            await DataStore.AddTank(myNewTank);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
