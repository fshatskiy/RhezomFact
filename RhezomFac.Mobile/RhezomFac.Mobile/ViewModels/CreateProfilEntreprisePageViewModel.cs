using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace RhezomFac.Mobile.ViewModels
{
    public class CreateProfilEntreprisePageViewModel : ViewModelBase
    {
        private readonly IProfilEntrepriseService profilEntrepriseService;
        private string nomCommercial;
        private string adrEntr;
        private string numTVA;
        private string pays;
        private string telEntr;
        private string numFax;
        private string mailEntr;
        private string lienWeb;
        private string iBAN;
        private string bIC;
        private string bCE;
        private IEnumerable<ProduitModel> produits;

        public string NomCommercial { get => nomCommercial; set => SetProperty(ref nomCommercial, value); }
        public string AdrEntr       { get => adrEntr; set => SetProperty(ref adrEntr, value); }
        public string NumTVA        { get => numTVA; set => SetProperty(ref numTVA, value); }
        public string Pays          { get => pays; set => SetProperty(ref pays, value); }
        public string TelEntr       { get => telEntr; set => SetProperty(ref telEntr, value); }
        public string NumFax        { get => numFax; set => SetProperty(ref numFax, value); }
        public string MailEntr      { get => mailEntr; set => SetProperty(ref mailEntr, value); }
        public string LienWeb       { get => lienWeb; set => SetProperty(ref lienWeb, value); }
        public string IBAN          { get => iBAN; set => SetProperty(ref iBAN, value); }
        public string BIC           { get => bIC; set => SetProperty(ref bIC, value); }
        public string BCE           { get => bCE; set => SetProperty(ref bCE, value); }
        public IEnumerable<ProduitModel> Produits { get => produits; set => produits = value; }

        #region commands
        public ICommand SaveCommand { get; private set; }
        public ICommand AddProductCommand { get; private set; }

        #endregion

        public CreateProfilEntreprisePageViewModel(INavigationService navigationService, IProfilEntrepriseService profilEntrepriseService) : base(navigationService)
        {
            SaveCommand = new DelegateCommand(SaveProfilEntreprise);
            AddProductCommand = new DelegateCommand(AddProduct);
            this.profilEntrepriseService = profilEntrepriseService;
        }

        private void AddProduct()
        {
            // ToDo add product

        }

        private async void SaveProfilEntreprise()
        {
            // TODO Check if all required fields are filled.
            ProfilEntrepriseModel profilEntrepriseModel = new ProfilEntrepriseModel
            {
                NomCommercial = NomCommercial,
                AdrEntr = AdrEntr,
                NumTVA = NumTVA,
                Pays = Pays,
                TelEntr = TelEntr,
                NumFax = NumFax,
                MailEntr = MailEntr,
                LienWeb = LienWeb,
                IBAN = IBAN,
                BIC = BIC,
                BCE = BCE

                // .. To do others fields;

            };

            bool success = await profilEntrepriseService.SaveProfilEntreprise(profilEntrepriseModel);
            if (success)
            {
                await NavigationService.GoBackAsync(); //go back
            }
        }


    }
}
