using System.ComponentModel;
using System.Windows.Input;
using WpfApplication1.Commands;

namespace WpfApplication1.ViewModels
{
    public class FormViewModel : ViewModelbase
    {
        private double _long;
        private double _lat;
        private int _rad;
        private ICommand _command;
        private NavigationStore _navigationStore;
        
        public double Long
        {
            get { return _long;} set { _long = value; OnPropertyChanged("Long"); }
        } 
        
        public double Lat
        {
            get { return _lat;} set { _lat = value; OnPropertyChanged("Lat"); }
        } 
        
        public int Rad
        {
            get { return _rad;} set { _rad = value; OnPropertyChanged("Rad"); }
        }
        
        
        public ICommand SubmitCommand
        {
            get
            {
                resetVM();
                return _command;
            }
            set { _command = value; }
        }

        public void resetVM()
        {
            SubmitCommand = new NavigateCommand(_navigationStore, new ResultViewModel(_long, _lat, _rad));
        }

        public FormViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _command = new NavigateCommand(_navigationStore, new ResultViewModel(_long,_lat,_rad));
        }
    }
}