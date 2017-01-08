using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp2.ViewModels
{
    using System.Threading.Tasks;

    using Prism.Navigation;

    public class PrismMasterDetailPage1ViewModel : BindableBase
    {
        private readonly INavigationService navigationService;
        private async Task Navigate(string name)
        {
            await this.navigationService.NavigateAsync(name);
        }
        public PrismMasterDetailPage1ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.NavigateCommand = new DelegateCommand<string>(async x => await this.Navigate(x));
        }

        /// <summary>
        /// Gets or sets the navigate command.
        /// </summary>
        public DelegateCommand<string> NavigateCommand { get; set; }

    }
}
