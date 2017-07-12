using Xamarin.Forms;
using XamarinAllianceApp.Models;
using XamarinAllianceApp.ViewModels;

namespace XamarinAllianceApp.Views
{
    public partial class CharacterListPage : ContentPage
    {
        private CharacterListViewModel viewModel;

        public CharacterListPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CharacterListViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Character;
            if (item == null) 
            {
                // the item was deselected
                return;
            }

            // Navigate to the detail page
            await Navigation.PushAsync(new CharacterDetailPage(new CharacterDetailViewModel(item)));

            // Manually deselect item
            characterList.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

    }
}

