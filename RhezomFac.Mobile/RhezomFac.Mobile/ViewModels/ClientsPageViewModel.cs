using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using RhezomFac.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace RhezomFac.Mobile.ViewModels
{
    public class ClientsPageViewModel : ViewModelBase
    {
        #region Properties
        private readonly IClientsService clientsService;

        private IEnumerable<ClientModel> clientsList;
        public IEnumerable<ClientModel> ClientsList
        {
            get => clientsList;
            set => SetProperty(ref clientsList, value);
        }

        #endregion

        #region Commands
        /// <summary>
        /// Bouton d'ajout
        /// </summary>
        public ICommand AddNewClientCommand { get; private set; }
        public ICommand RemoveClientCommand { get; private set; }
        #endregion
        public ClientsPageViewModel(INavigationService navigationService, IClientsService clientsService) : base(navigationService)
        {
            AddNewClientCommand = new DelegateCommand(AddNewClient);
            RemoveClientCommand = new DelegateCommand(RemoveClient);

            this.clientsService = clientsService;
        }

        //initialisation de vue : pour récup liste de produits
        public override void Initialize(INavigationParameters parameters)
        {
            InitData();
        }

        // à remplacer aussi pour l'api
        private void InitData()
        {
            ClientsList = new List<ClientModel>
            {
                new ClientModel
                {
                    //try data static
                    Nom = "Dupont",
                    Prenom = "Alex",
                    Adresse = "Rue Ech",
                    Mail = "dupont@hotmail.com",
                    Tel = "0485551423",
                    NumTVA = "BE 1251846231",
                    EstActif = true
                },
                new ClientModel
                {
                    //try data static
                    Nom = "Dupont2",
                    Prenom = "Alex",
                    Adresse = "Rue Ech",
                    Mail = "dupont@hotmail.com",
                    Tel = "0485551423",
                    NumTVA = "BE 1251846231",
                    EstActif = true
                }
            };
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            //base.OnNavigatedTo(parameters);
            //InitData();
        }

        private void AddNewClient()
        {
            NavigationService.NavigateAsync(nameof(CreateClientPage));
        }

        private void RemoveClient()
        {
            // TODO:
            NavigationService.NavigateAsync(nameof(CreateClientPage));
        }


        //private async void InitData()
        //{
        //    // CAll
        //    ClientsList = await clientsService.GetClients();
        //}
    }
}
