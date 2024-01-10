using System;

namespace WpfApplication1.ViewModels
{
    public class NavigationStore
    {
        private ViewModelbase _currentViewModel;

        public ViewModelbase CurrentViewmodel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;
    }
}