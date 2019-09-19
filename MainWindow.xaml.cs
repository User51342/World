using System.Windows;
using System.Windows.Input;

namespace World
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(this);
        }

        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MainViewModel viewModel = DataContext as MainViewModel;
                if (viewModel != null)
                {
                    viewModel.Stop();
                }
                this.Close();
            }
        }
    }
}
