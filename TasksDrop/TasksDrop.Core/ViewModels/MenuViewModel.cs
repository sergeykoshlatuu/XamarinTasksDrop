using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace TasksDrop.Core.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowTasksCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<TasksDropViewModel>());

        }

        // MvvmCross Lifecycle

        // MVVM Properties

        // MVVM Commands
        public IMvxCommand ShowTasksCommand { get; private set; }
       
        // Private methods
    }
}