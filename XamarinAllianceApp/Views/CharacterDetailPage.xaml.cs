using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinAllianceApp.ViewModels;

namespace XamarinAllianceApp.Views
{
	public partial class CharacterDetailPage : ContentPage
	{
        CharacterDetailViewModel viewModel;

        public CharacterDetailPage(CharacterDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
