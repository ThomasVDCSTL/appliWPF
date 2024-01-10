using System;
using System.Windows;
using WpfApplication1.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // _navigationStore.CurrentViewmodel = new ResultViewModel(5.731507, 45.185018, 100);
            _navigationStore.CurrentViewmodel = new FormViewModel(_navigationStore);
            MainWindow=new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}