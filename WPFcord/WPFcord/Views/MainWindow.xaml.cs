using System.Windows;
using System.Windows.Controls;

namespace WPFcord.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void DataGrid_CellEditEnding(object sender, System.Windows.Controls.DataGridCellEditEndingEventArgs e)
        {
            var tb = e.EditingElement as TextBox;
            var newValue = tb.Text;
        }
    }
}
