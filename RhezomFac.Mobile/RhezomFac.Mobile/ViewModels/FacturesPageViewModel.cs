using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using RhezomFac.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RhezomFac.Mobile.ViewModels
{
	public class FacturesPageViewModel : ViewModelBase
	{
        #region Properties
        private readonly IFacturesService facturesService;

        private IEnumerable<FactureModel> facturesList;
        public IEnumerable<FactureModel> FacturesList
        {
            get => facturesList;
            set => SetProperty(ref facturesList, value);
        }

        #endregion

        #region Commands
        /// <summary>
        /// Bouton d'ajout
        /// </summary>
        public ICommand AddNewInvoiceCommand { get; private set; }
        public ICommand DeleteInvoiceCommand { get; private set; }
        #endregion
        public FacturesPageViewModel(INavigationService navigationService, IFacturesService facturesService) : base(navigationService)
        {
            AddNewInvoiceCommand = new DelegateCommand(AddNewInvoice);
            DeleteInvoiceCommand = new DelegateCommand(DeleteInvoice);
            this.facturesService = facturesService;
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            InitData();

        }


        private void AddNewInvoice()
        {
            NavigationService.NavigateAsync(nameof(CreateFacturePage));
        }
        private void DeleteInvoice()
        {
            //TODO:
        }


        private async void InitData()
        {
            // CAll
            FacturesList = await facturesService.GetFactures();
        }
    }
}
