using PeriodicTableWPF.Model;
using System.Windows;
using System.Windows.Input;

namespace PeriodicTableWPF;

public partial class MainWindow : Window
{
    ViewModel viewModel;
    public MainWindow()
    {
        InitializeComponent();
        viewModel = new ViewModel();
    }

    private void OpenActinides(object sender, MouseButtonEventArgs e)
    {
        viewModel.OpenActinidesWindow();
    }

    private void OpenLantanides(object sender, MouseButtonEventArgs e)
    {
        viewModel.OpenLantanindesWindow();
    }
}
