using Prism;
using Prism.Ioc;
using RhezomFac.Mobile.Services;
using RhezomFac.Mobile.Services.Interfaces;
using RhezomFac.Mobile.ViewModels;
using RhezomFac.Mobile.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace RhezomFac.Mobile
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/HomeMasterDetailPage");//lie (stack) comme Django + ajoute la toolbar
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            containerRegistry.RegisterForNavigation<HomeMasterDetailPage, HomeMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<FacturesPage, FacturesPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateFacturePage, CreateFacturePageViewModel>();
            containerRegistry.RegisterForNavigation<DevisPage, DevisPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateProfilEntreprisePage, CreateProfilEntreprisePageViewModel>();

            //Add Services to DI container. va instancier les instances et les injecter dans le construct
            containerRegistry.Register<IFacturesService, FacturesService>();
            containerRegistry.Register<IClientsService, ClientsService>();
            containerRegistry.Register<IDevisService, DevisService>();
            containerRegistry.Register<IProduitService, ProduitService>();
            containerRegistry.Register<IProfilEntrepriseService, ProfilEntrepriseService>();
            containerRegistry.RegisterForNavigation<ClientsPage, ClientsPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateClientPage, CreateClientPageViewModel>();
            containerRegistry.RegisterForNavigation<CreateDevisPage, CreateDevisPageViewModel>();
        }
    }
}
