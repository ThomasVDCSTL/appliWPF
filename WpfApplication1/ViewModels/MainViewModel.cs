using System;

namespace WpfApplication1.ViewModels
{
    public class MainViewModel : ViewModelbase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelbase CurrentViewModel => _navigationStore.CurrentViewmodel;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}