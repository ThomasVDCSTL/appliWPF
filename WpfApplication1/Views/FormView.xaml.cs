using System.Windows.Controls;
using WpfApplication1.ViewModels;

namespace WpfApplication1.Views
{
    public partial class FormView : UserControl
    {
        public FormViewModel FormViewModel;
        public FormView()
        {
            InitializeComponent();
            // FormViewModel = new FormViewModel();
            // DataContext = FormViewModel;
        }
    }
}