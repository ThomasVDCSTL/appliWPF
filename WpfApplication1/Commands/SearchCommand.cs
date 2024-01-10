using System.Globalization;
using API_TAG_lib;

namespace WpfApplication1.Commands
{
    public class SearchCommand : CommandBase
    {
        private StopByCoord _req;
        private double _lon;
        private double _lat;
        private int _rad;
        
        
        public SearchCommand(StopByCoord req, double lon, double lat, int rad)
        {
            _lon = lon;
            _lat = lat;
            _rad = rad;
            _req = req;
        }
        
        
        public override void Execute(object parameter)
        {
            _req= new StopByCoord(_lon.ToString(CultureInfo.InvariantCulture),_lat.ToString(CultureInfo.InvariantCulture),_rad.ToString());
        }
    }
}