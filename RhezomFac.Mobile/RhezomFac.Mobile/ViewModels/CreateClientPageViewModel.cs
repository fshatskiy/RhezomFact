using Prism.Commands;
using Prism.Navigation;
using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RhezomFac.Mobile.ViewModels
{
    public class CreateClientPageViewModel : ViewModelBase
    {
        #region Properties
        private readonly IClientsService clientsService;

        private string nom;
        public string Nom
        {
            get => nom;
            set => SetProperty(ref nom, value);
        }

        private string prenom;
        public string Prenom
        {
            get => prenom;
            set => SetProperty(ref prenom, value);
        }

        private string adresse;
        public string Adresse
        {
            get => adresse;
            set => SetProperty(ref adresse, value);
        }

        private string mail;
        public string Mail
        {
            get => mail;
            set => SetProperty(ref mail, value);
        }

        private string tel;
        public string Tel
        {
            get => tel;
            set => SetProperty(ref tel, value);
        }

        private string numTVA;
        public string NumTVA
        {
            get => numTVA;
            set => SetProperty(ref numTVA, value);
        }

        private bool estActif;
        public bool EstActif
        {
            get => estActif;
            set => SetProperty(ref estActif, value);
        }

        #endregion
        #region commands
        public ICommand SaveCommand { get; private set; }

        #endregion
        public CreateClientPageViewModel(INavigationService navigationService, IClientsService clientsService) : base(navigationService)
        {
            SaveCommand = new DelegateCommand(SaveClient);
            this.clientsService = clientsService;
        }

        private async void SaveClient()
        {
            // TODO Check if all required fields are filled.
            bool success = false;
            if (success)
            {
                success = false;

                ClientModel clientModel = new ClientModel
                {
                    Nom = Nom,
                    Prenom = Prenom,
                    Adresse = Adresse,
                    Mail = Mail,
                    Tel = Tel,
                    NumTVA = NumTVA
                    // .. To do others fields;
                };

                success = await clientsService.SaveClient(clientModel);
                if (success)
                {
                    await NavigationService.GoBackAsync(); //go back
                }
            }
        }
    }
}
