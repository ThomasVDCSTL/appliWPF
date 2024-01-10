using WpfApplication1.ViewModels;

namespace WpfApplication1.Commands
{
    public class NavigateCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private ViewModelbase _viewModel;

        public NavigateCommand(NavigationStore navigationStore, ViewModelbase viewModel)
        {
            _navigationStore = navigationStore;
            _viewModel = viewModel;
        }

        public void ResetVM(ViewModelbase vm)
        {
            _viewModel = vm;
        }
        
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewmodel = _viewModel;
        }
    }
}

// 5.731507
// 45.185018
// 100