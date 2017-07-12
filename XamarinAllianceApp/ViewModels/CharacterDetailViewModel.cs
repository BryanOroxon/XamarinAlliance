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
    public class CharacterDetailViewModel : BaseViewModel
    {
        public Character Item { get; set; }
 
        public CharacterDetailViewModel(Character item = null)
        {
            Title = item.Name;
            Item = item;
        }
    }
}
