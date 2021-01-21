using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace RhezomFac.Mobile.ViewModels
{
    public class HomeMasterDetailPageViewModel : ViewModelBase
	{
        #region commands
        public ICommand MenuItemClickCommand { get; private set; }
        #endregion

        public HomeMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            MenuItemClickCommand = new DelegateCommand<string>(MenuItemClick);
        }

        private void MenuItemClick(string pageName)
        {
            NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{pageName}");
        }

    }
}
