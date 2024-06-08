using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Google_Tv_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;

            SearchViewModel viewModel = new SearchViewModel();
            BindingContext = viewModel;

            SearchBar searchBar = new SearchBar { Placeholder = "Search items..." };
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            // Handle page loaded event
        }

        private void OnMainPageClicked(object sender, EventArgs e)
        {
            // Handle main page button click
        }

        private void OnFavoritesClicked(object sender, EventArgs e)
        {
            // Handle favorites button click
        }
    }

    public class SearchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
