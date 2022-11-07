using PeriodicTableWPF.Views;

namespace PeriodicTableWPF.Model;

public class ViewModel
{
    public void OpenLantanindesWindow() => new LanthanidesWindow().ShowDialog();
    public void OpenActinidesWindow() => new ActinidesWindow().ShowDialog();

}
