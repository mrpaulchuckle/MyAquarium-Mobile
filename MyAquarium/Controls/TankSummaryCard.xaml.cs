using MyAquarium.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAquarium.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TankSummaryCard : ContentView
    {

        public static readonly BindableProperty IDProperty = BindableProperty.Create("ID", typeof(int), typeof(TankSummaryCard), null);
        public static readonly BindableProperty IsFavouriteProperty = BindableProperty.Create("IsFavorite", typeof(bool), typeof(TankSummaryCard), false);
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(TankSummaryCard), string.Empty);
        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create("Description", typeof(string), typeof(TankSummaryCard), string.Empty);
        public TankSummaryCard()
        {
            InitializeComponent();
        }

        public int ID
        {
            get => (int)GetValue(IDProperty);
            set => SetValue(IDProperty, value);
        }

        public bool IsFavourite
        {
            get => (bool)GetValue(IsFavouriteProperty);
            set => SetValue(IsFavouriteProperty, value);
        }

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }
    }
}