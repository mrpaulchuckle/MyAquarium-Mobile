using MyAquarium.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAquarium.ViewModels
{
    public class TankViewModel : BaseViewModel
    {
        private string _Description;
        public int? ID { get; set; }

        public string Description
        {
            get => _Description;
            set => SetProperty(ref _Description, value);
        }
    }
}
