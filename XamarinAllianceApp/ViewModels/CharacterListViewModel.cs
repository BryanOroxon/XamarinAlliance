using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAllianceApp.Helpers;
using XamarinAllianceApp.Models;
using XamarinAllianceApp.Services;

namespace XamarinAllianceApp.ViewModels
{
    public class CharacterListViewModel : BaseViewModel
    {
        CharacterService service;

        public ObservableRangeCollection<Character> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public CharacterListViewModel()
        {
            service = new CharacterService();
            Items = new ObservableRangeCollection<Character>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }


        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await service.GetCharactersAsync();
                Items.ReplaceRange(items);
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

    }
}
