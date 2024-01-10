using System.Windows.Controls;
using WpfApplication1.ViewModels;

namespace WpfApplication1.Views
{
    public partial class ResultView : UserControl
    {
        public ResultViewModel ResultViewModel;
        public ResultView()
        {
            InitializeComponent();
            // ResultViewModel = new ResultViewModel(5.731507, 45.185018, 100);
            // DataContext = ResultViewModel;
        }
    }
}