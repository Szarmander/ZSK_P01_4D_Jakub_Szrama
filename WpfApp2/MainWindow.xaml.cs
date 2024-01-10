using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowDataContext DC => (MainWindowDataContext)DataContext;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DC.UserName))
            {
                return;
            }

            DC.IsNameNeeded = false;
            MessageBox.Show($"Hello {DC.UserName}!");
        }
    }
}