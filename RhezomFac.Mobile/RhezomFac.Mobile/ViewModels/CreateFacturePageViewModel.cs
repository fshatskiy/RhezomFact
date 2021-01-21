using Prism.Commands;
using Prism.Navigation;
using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RhezomFac.Mobile.ViewModels
{
    public class CreateFacturePageViewModel : ViewModelBase
    {
        #region Properties
        private readonly IFacturesService facturesService;
        private readonly IClientsService clientsService;
        private readonly IProduitService produitService;
        private IEnumerable<ClientModel> clients;
        public IEnumerable<ClientModel> Clients
        {
            get => clients;
            set => SetProperty(ref clients, value);
        }

        private ClientModel selectedClient;
        public ClientModel SelectedClient
        {
            get => selectedClient;
            set => SetProperty(ref selectedClient, value);
        }

        private IEnumerable<ProduitModel> produits;
        public IEnumerable<ProduitModel> Produits
        {
            get => produits;
            set => SetProperty(ref produits, value);
        }

        private ProduitModel selectedProd;
        public ProduitModel SelectedProd
        {
            get => selectedProd;
            set => SetProperty(ref selectedProd, value);
        }

        private IEnumerable<ProduitModel> selectedProductsList;
        public IEnumerable<ProduitModel> SelectedProductsList
        {
            get => selectedProductsList;
            set => SetProperty(ref selectedProductsList, value);
        }

        private string infoAdd;
        public string InfoAdd
        {
            get => infoAdd;
            set => SetProperty(ref infoAdd, value);
        }

        #endregion

        #region commands
        public ICommand SaveCommand { get; private set; }
        public ICommand AddProductCommand { get; private set; }
        public ICommand RemoveProductCommand { get; private set; }

        #endregion

        public CreateFacturePageViewModel(INavigationService navigationService,
            IFacturesService facturesService,
            IClientsService clientsService,
            IProduitService produitService) : base(navigationService)
        {
            SaveCommand = new DelegateCommand(SaveFacture);
            AddProductCommand = new DelegateCommand(AddProduct);
            RemoveProductCommand = new DelegateCommand<ProduitModel>(RemoveProduct);
            this.facturesService = facturesService;
            this.clientsService = clientsService;
            this.produitService = produitService;
        }

        //initialisation de vue : pour récup liste de produits
        public override void Initialize(INavigationParameters parameters)
        {
            InitData();
        }

        // à remplacer aussi pour l'api
        private async  void InitData()
        {
            Produits = await produitService.GetProduits();
        }

        private void AddProduct()
        {
            // si SelectedProductsList==null alors .ToList sinon si ==null aussi alors crée un liste
            var tempList = SelectedProductsList?.ToList() ?? new List<ProduitModel>();

            // TODO: Ajouter la quantité du produit!
            tempList.Add(SelectedProd);
            SelectedProductsList = tempList;
        }

        private void RemoveProduct(ProduitModel produitModel) {
            var tempList = SelectedProductsList?.ToList() ?? new List<ProduitModel>();
            tempList.Remove(produitModel);
            SelectedProductsList = tempList;
        }

        private async void SaveFacture()
        {
            // TODO Check if all required fields are filled.
            bool success = true;
            //success = await SaveClient();

            if (success)
            {
                success = false;

                FactureModel factureModel = new FactureModel
                {
                    DateEcheance = DateTime.Today.Date,
                    Produits = Produits,
                    InfoAdd = InfoAdd
                };

                success = await facturesService.SaveInvoice(factureModel);
                if (success)
                {
                    await NavigationService.GoBackAsync(); //go back
                }
            }
        }

        //private async Task<bool> SaveClient()
        //{
        //    ClientModel clientModel = new ClientModel
        //    {
        //        Nom = Nom,
        //        Prenom = Prenom,
        //        Adresse = Adresse,
        //        Mail = Mail,
        //        Tel = Tel,
        //        NumTVA = NumTVA
        //        // .. To do others fields;
        //    };

            //return await clientsService.SaveClient(clientModel);

            //vérif qu'il a bien été sauvé
            //bool success = await facturesService.SauverClient(factureModel);
            //if (success)
            //{
            //    SaveInvoice(); //et go back...
            //}
        //}


    }
}
