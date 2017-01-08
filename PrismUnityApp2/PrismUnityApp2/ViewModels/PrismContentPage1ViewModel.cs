using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp2.ViewModels
{
    using System.Threading.Tasks;

    using Prism.Navigation;

    public class PrismContentPage1ViewModel : BindableBase
    {
        private readonly INavigationService navigationService;

        public PrismContentPage1ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            NavigateCommand=new DelegateCommand(async()=>await NavigateAsync());
        }

        private async Task NavigateAsync()
        {
            await this.navigationService.NavigateAsync("PrismNavigationPage1/PrismContentPage3");
        }

        public DelegateCommand NavigateCommand { get; set; }
    }
}
