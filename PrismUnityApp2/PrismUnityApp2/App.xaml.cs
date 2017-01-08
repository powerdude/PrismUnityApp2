using Prism.Unity;
using PrismUnityApp2.Views;

namespace PrismUnityApp2
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("PrismMasterDetailPage1/PrismNavigationPage1/PrismTabbedPage1");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<PrismMasterDetailPage1>();
            Container.RegisterTypeForNavigation<PrismTabbedPage1>();
            Container.RegisterTypeForNavigation<PrismNavigationPage1>();
            Container.RegisterTypeForNavigation<PrismContentPage1>();
            Container.RegisterTypeForNavigation<PrismContentPage2>();
            Container.RegisterTypeForNavigation<PrismContentPage3>();
        }
    }
}
