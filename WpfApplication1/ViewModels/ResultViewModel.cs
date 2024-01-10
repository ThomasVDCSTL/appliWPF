using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using API_TAG_lib;
using Microsoft.Maps.MapControl.WPF;

namespace WpfApplication1.ViewModels
{
    public class ResultViewModel : ViewModelbase
    {
        private StopByCoord _req ;
        private List<BusStop> _stopList;

        public ObservableCollection<Location> PushPins
        {
            get
            {
                List<Location> coord = new List<Location>();
                foreach (BusStop stop in _stopList)
                {
                    coord.Add(new Location(Convert.ToDouble(stop.Lat, CultureInfo.InvariantCulture), Convert.ToDouble(stop.Lon, CultureInfo.InvariantCulture)));
                }

                return new ObservableCollection<Location>(coord);
            }
        }
        
        public List<BusStop> GetStopsAround()
        {
            _stopList = _req.GetStopList;
            return _stopList;
        }

        public ObservableCollection<BusStop> GetStopsAroundCamp
        {
            get
            {
                GetStopsAround();
                return new ObservableCollection<BusStop>(_stopList);
            }
        }

        public ResultViewModel(double x, double y, int radius)
        {
            // _req = new StopByCoord(x.ToString(CultureInfo.InvariantCulture), y.ToString(CultureInfo.InvariantCulture),
            //     radius.ToString());
            _req = new StopByCoord("5.731507", "45.185018", "100");
        }

        public ICommand search
        {
            get;
        }
        
        
    }
}