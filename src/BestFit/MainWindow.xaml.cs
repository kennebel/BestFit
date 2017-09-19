using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BestFit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel
        {
            get { return (MainViewModel)this.DataContext; }
            set { this.DataContext = value; }
        }

        public MainWindow() : this(viewModel: null) { }

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();

            if (viewModel == null) { viewModel = new MainViewModel(); }
            ViewModel = viewModel;
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
