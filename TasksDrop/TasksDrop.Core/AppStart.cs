using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TasksDrop.Core.ViewModels;

namespace TasksDrop.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<TasksDropViewModel>();
        }
    }
}
