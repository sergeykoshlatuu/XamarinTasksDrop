using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace TasksDrop.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowTasksDropViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<TasksDropViewModel>());
           
        }

        // MvvmCross Lifecycle

        // MVVM Properties

        // MVVM Commands
        public IMvxAsyncCommand ShowTasksDropViewModelCommand { get; private set; }
       

        // Private methods
    }
}